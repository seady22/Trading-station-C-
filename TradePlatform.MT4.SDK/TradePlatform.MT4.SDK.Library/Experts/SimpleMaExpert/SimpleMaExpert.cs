using System;
using System.Configuration;
using System.Linq;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.Library.Config;
using TradePlatform.MT4.SDK.Library.Handlers;
using log4net;

namespace TradePlatform.MT4.SDK.Library.Experts.SimpleMaExpert
{
    public class SimpleMaExpert : ExtendedExpertAdvisor
    {
        public IRepository<ExpertDetails> ExpertDetailsRepository = new Repository<ExpertDetails>();
        private ILog _logger = LogManager.GetLogger(typeof(SimpleMaExpert));
        private ExpertElement _config;
        private string _symbol;

        protected override int DeInit()
        {
            return 1;
        }

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

        private void GetConfig()
        {
            var section = (ExpertConfiguration)ConfigurationManager.GetSection("ExpertConfiguration");
            _config = section.Experts["SimpleMaExpert"];
        }

        private void GetSymbol()
        {
            _symbol = this.Symbol();
        }

        private TIME_FRAME GetCurrentTimeFrame()
        {
            var timeFrame = (TIME_FRAME)Enum.Parse(typeof(TIME_FRAME), _config.TimeFrame);
            return timeFrame;
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
                    var ordersInDb = ExpertDetailsRepository.GetAll().Where(x => x.ClosedOn == null && x.Pair == _symbol && x.ExpertName == GetType().Name);
                    var orderSymbol = this.OrderSymbol();
                    if (orderSymbol == _symbol && ordersInDb.Count() == 1)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        private void UpdateOrdersInDb()
        {
            var ordersInDb = ExpertDetailsRepository.GetAll().Where(x => x.ClosedOn == null && x.Pair == _symbol && x.ExpertName == GetType().Name);
            foreach (ExpertDetails details in ordersInDb)
            {
                details.ClosedOn = DateTime.Now;
                details.BalanceOnClose = this.AccountBalance();
                details.State = State.Closed.ToString();
                details.Profit = (double)(details.BalanceOnClose - details.BalanceOnCreate);
                ExpertDetailsRepository.Update(details);

                _logger.DebugFormat("OrderId={0}. Order was updated. ClosedOn={1}, BalanceOnClosed={2}, State={3}, Profit={4}, Pair={5}", details.Id, details.ClosedOn, details.BalanceOnClose, details.State, details.Profit, details.Pair);
                break;
            }
        }

        private TREND_TYPE GetTrendType()
        {
            var result = TREND_TYPE.OTHER;
            var timeFrame = GetCurrentTimeFrame();
            var sma21Price = this.iMA(_symbol, timeFrame, 21, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var sma70Price = this.iMA(_symbol, timeFrame, 70, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);

            if (sma21Price >= sma70Price)
            {
                result = TREND_TYPE.ASC;
            }

            if (sma21Price <= sma70Price)
            {
                result = TREND_TYPE.DESC;
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
                var takeProfit = bid + int.Parse(_config.TakeProfit) * point;
                var stopLoss = bid - int.Parse(_config.StopLoss) * point;
                result = this.OrderSend(_symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 3,
                                            stopLoss, takeProfit);
                _logger.DebugFormat("Open buy offer. Ask price={0}, StopLoss={1}, TakeProfit={2}, Symbol={3}", ask, stopLoss, takeProfit, _symbol);

                if (result == -1)
                {
                    result = this.OrderSend(_symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 3,
                                   stopLoss, takeProfit);
                    _logger.DebugFormat("OpenOffer was sent second time. Result = {0}", result);
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
                var takeProfit = ask - int.Parse(_config.TakeProfit) * point;
                var stopLoss = ask + int.Parse(_config.StopLoss) * point;
                result = this.OrderSend(_symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid,
                                            3, stopLoss, takeProfit);
                _logger.DebugFormat("Open sell offer. Bid price={0}, StopLoss={1}, TakeProfit={2}, Symbol={3}", bid, stopLoss, takeProfit, _symbol);

                if (result == -1)
                {
                    result = this.OrderSend(_symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid, 3,
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
                ExpertName = GetType().Name,
                OrderId = result
            };
            ExpertDetailsRepository.Save(expertDetailRecord);
            _logger.DebugFormat("New expertDetail Record was added. Id={0}. Pair={1}, TrendType={2}", expertDetailRecord.Id, expertDetailRecord.Pair, expertDetailRecord.TrendType);
        }

        private bool CanOpenOffer(TREND_TYPE trendType)
        {
            var result = false;
            var timeFrame = GetCurrentTimeFrame();
            
            var sma21Price = this.iMA(_symbol, timeFrame, 21, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var sma70Price = this.iMA(_symbol, timeFrame, 70, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);

            var lastTwoBarsClosePrice = this.Close(2);
            var lastOneBarClosePrice = this.Close(1);
            var lastThreeBarPrice = this.Close(3);

            if (trendType == TREND_TYPE.ASC)
            {
                if (lastThreeBarPrice<sma21Price && lastThreeBarPrice > sma70Price && lastTwoBarsClosePrice > sma21Price && lastOneBarClosePrice > sma21Price)
                {
                    result = true;
                    _logger.DebugFormat("Can open ASC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    _logger.DebugFormat("Sma21Price={0}, Sma70Price={1}", sma21Price, sma70Price);
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (lastThreeBarPrice>sma21Price && lastThreeBarPrice < sma70Price && lastTwoBarsClosePrice < sma21Price && lastOneBarClosePrice < sma21Price)
                {
                     result = true;
                    _logger.DebugFormat("Can open DESC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                     _logger.DebugFormat("Sma21Price={0}, Sma70Price={1}", sma21Price, sma70Price);
                }
            }

            return result;
        }




    }
}
