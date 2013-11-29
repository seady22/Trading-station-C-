using System;
using System.Configuration;
using System.Linq;
using log4net;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.Library.Config;
using TradePlatform.MT4.SDK.Library.Handlers;

namespace TradePlatform.MT4.SDK.Library.Experts.LineBalanceAdvisor
{
    public abstract class LineBalanceAdvisor : ExtendedExpertAdvisor
    {
        public IRepository<ExpertDetails> ExpertDetailsRepository = new Repository<ExpertDetails>();
        private ILog _logger = LogManager.GetLogger(typeof(LineBalanceAdvisor));
        private ExpertElement _config;
        private string _symbol;

        protected override int Init()
        {
            return 1;
        }

        protected override int Start()
        {
            GetConfig();
            GetSymbol();
            if (!IsOrderOpenForSymbol())
            {
                UpdateOrdersInDb();
                var trendType = GetTrendType();
                if (CanOpenOffer(trendType))
                {
                    OpenOffer(trendType);
                }
            }
            return 1;
        }

        private void GetSymbol()
        {
            _symbol = this.Symbol();
        }

        private void GetConfig()
        {
            var section = (ExpertConfiguration) ConfigurationManager.GetSection("ExpertConfiguration");
            _config = section.Experts["LineBalanceAdvisor"];
        }

        protected override int DeInit()
        {
            return 1;
        }

        private bool IsOrderOpenForSymbol()
        {
            var result = false;
            var ordersTotal = this.OrdersTotal();
            for (int i = 0; i < ordersTotal; i++)
            {
                var isOrderSelected = this.OrderSelect(i, SELECT_BY.SELECT_BY_POS);
                if (isOrderSelected)
                {
                    var orderSymbol = this.OrderSymbol();
                    if (orderSymbol == _symbol)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        private void UpdateOrdersInDb()
        {
            var ordersInDb = ExpertDetailsRepository.GetAll().Where(x => x.ClosedOn == null && x.Pair == _symbol);
            foreach (ExpertDetails details in ordersInDb)
            {
                details.ClosedOn = DateTime.Now;
                details.BalanceOnClose = this.AccountBalance();
                details.State = State.Closed.ToString();
                details.Profit = (double) (details.BalanceOnClose - details.BalanceOnCreate);
                ExpertDetailsRepository.Update(details);

                _logger.DebugFormat("OrderId={0}. Order was updated. ClosedOn={1}, BalanceOnClosed={2}, State={3}, Profit={4}, Pair={5}", details.Id, details.ClosedOn, details.BalanceOnClose, details.State, details.Profit, details.Pair);
                break;
            }
        }

        private TREND_TYPE GetTrendType()
        {
            var result = TREND_TYPE.OTHER;
            var timeFrame = GetCurrentTimeFrame();
            var ema25Price = this.iMA(_symbol, timeFrame, 25, 8, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var askPrice = this.Ask();
            var bidPrice = this.Bid();

            if (askPrice >= ema25Price && bidPrice >= ema25Price)
            {
                result = TREND_TYPE.ASC;
            }

            if (askPrice <= ema25Price && bidPrice <= ema25Price)
            {
                result = TREND_TYPE.DESC;
            }
            return result;
        }

        private TIME_FRAME GetCurrentTimeFrame()
        {
            var timeFrame = (TIME_FRAME) Enum.Parse(typeof (TIME_FRAME), _config.TimeFrame);
            return timeFrame;
        }
        private bool CanOpenOffer(TREND_TYPE trendType)
        {
            var result = false;
            var timeFrame = GetCurrentTimeFrame();
            var ema25Price = this.iMA(_symbol, timeFrame, 25, 8, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var lastTwoBarsClosePrice = this.Close(2);
            var lastOneBarClosePrice = this.Close(1);
            var lastThreeBarPrice = this.Close(3);

            if (trendType == TREND_TYPE.ASC)
            {
                if (ema25Price > lastThreeBarPrice && ema25Price < lastOneBarClosePrice &&
                    ema25Price < lastTwoBarsClosePrice)
                {
                    result = true;
                    _logger.DebugFormat("Can open ASC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    _logger.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}", ema25Price, lastOneBarClosePrice);
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (lastThreeBarPrice > ema25Price && lastTwoBarsClosePrice<ema25Price && lastOneBarClosePrice<ema25Price)
                {
                    result = true;
                    _logger.DebugFormat("Can open DESC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                   _logger.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}", ema25Price, lastOneBarClosePrice);
                }
            }

            return result;
        }

        public void OpenOffer(TREND_TYPE trendType)
        {
            var point = this.Point();
            var accountBalance = this.AccountBalance();
            var result = -1;

            if (trendType == TREND_TYPE.ASC)
            {
                double ask = this.Ask();
                double bid = this.Bid();
                var takeProfit = bid + int.Parse(_config.TakeProfit)*point;
                var stopLoss = bid - int.Parse(_config.StopLoss)*point;
                result = this.OrderSend(_symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 3,
                                            stopLoss, takeProfit);
                _logger.DebugFormat("Open buy offer. Ask price={0}, StopLoss={1}, TakeProfit={2}, Symbol={3}", ask, stopLoss, takeProfit, _symbol);

                if (result == -1)
                {
                    result = this.OrderSend(_symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 3,
                                   stopLoss, takeProfit);
                  _logger.DebugFormat("OpenOffer was sent second time. Result = {0}",result);
                  if (result == -1)
                  {
                      _logger.DebugFormat("OpenOffer was not executed. Try later");
                      return;
                  }
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                double bid = this.Bid();
                double ask = this.Ask();
                var takeProfit = ask - int.Parse(_config.TakeProfit)*point;
                var stopLoss = ask + int.Parse(_config.StopLoss)*point;
                result = this.OrderSend(_symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid,
                                            3, stopLoss, takeProfit);
                _logger.DebugFormat("Open sell offer. Bid price={0}, StopLoss={1}, TakeProfit={2}, Symbol={3}", bid, stopLoss, takeProfit, _symbol);

                if (result == -1)
                {
                    result= this.OrderSend(_symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid, 3,
                                   stopLoss, takeProfit);
                  _logger.DebugFormat("OpenOffer was sent second time.Symbol={0}", _symbol);
                  if (result == -1)
                  {
                      _logger.DebugFormat("OpenOffer was not executed. Try later");
                      return;
                  }
                }
            }
            var expertDetailRecord = new ExpertDetails
                {
                    State = State.Active.ToString(),
                    CreatedOn = DateTime.Now,
                    Pair = _symbol,
                    TimeFrame = GetCurrentTimeFrame(),
                    TrendType = trendType.ToString(),
                    BalanceOnCreate = accountBalance,
                    ExpertName = GetType().ToString(),
                    OrderId = result
                };
            ExpertDetailsRepository.Save(expertDetailRecord);
            _logger.DebugFormat("New expertDetail Record was added. Id={0}. Pair={1}, TrendType={2}", expertDetailRecord.Id, expertDetailRecord.Pair, expertDetailRecord.TrendType);
        }
    }
}

