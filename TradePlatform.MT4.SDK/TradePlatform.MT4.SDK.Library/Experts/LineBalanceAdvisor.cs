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

namespace TradePlatform.MT4.SDK.Library.Experts
{
    public class LineBalanceAdvisor : ExtendedExpertAdvisor
    {
        public IRepository<ExpertDetails> ExpertDetailsRepository = new Repository<ExpertDetails>();
        private ILog _logger = LogManager.GetLogger("LineBalanceAdvisor");
        private ExpertElement _config;

        protected override int Init()
        {
            return 1;
        }

        protected override int Start()
        {
            var section = (ExpertConfiguration) ConfigurationManager.GetSection("ExpertConfiguration");
            _config = section.Experts["LineBalanceAdvisor"];
            if (!IsOrdersOpen())
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

        protected override int DeInit()
        {
            return 1;
        }

        private bool IsOrdersOpen()
        {
            var ordersTotal = this.OrdersTotal();
            if (ordersTotal>0)
            {
                return true;
            }
            return false;
        }

        private void UpdateOrdersInDb()
        {
            var ordersInDb = ExpertDetailsRepository.GetAll().Where(x => x.ClosedOn == null);
            foreach (ExpertDetails details in ordersInDb)
            {
                var currentOrder = details;
                currentOrder.ClosedOn = DateTime.Now;
                currentOrder.BalanceOnClose = this.AccountBalance();
                currentOrder.State = State.Closed;
                ExpertDetailsRepository.Update(currentOrder);

                _logger.DebugFormat("OrderId={0}. Order was updated. ClosedOn={1}, BalanceOnClosed={2}, State={3}", currentOrder.Id, currentOrder.ClosedOn, currentOrder.BalanceOnClose, currentOrder.State);
                break;
            }
        }

        private TREND_TYPE GetTrendType()
        {
            var result = TREND_TYPE.OTHER;
            var timeFrame = GetCurrentTimeFrame();
            var ema25Price = this.iMA(_config.Symbol, timeFrame, 25, 8, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
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

        private SymbolsEnum GetCurrentSymbol()
        {
            var symbol = (SymbolsEnum)Enum.Parse(typeof(SymbolsEnum), _config.Symbol);
            return symbol;
        }

        private bool CanOpenOffer(TREND_TYPE trendType)
        {
            var result = false;
            var timeFrame = GetCurrentTimeFrame();
            var ema25Price = this.iMA(_config.Symbol, timeFrame, 25, 8, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var lastTwoBarsClosePrice = this.Close(2);
            var lastOneBarClosePrice = this.Close(1);
            var lastThreeBarPrice = this.Close(3);

            if (trendType == TREND_TYPE.ASC)
            {
                if (ema25Price > lastThreeBarPrice && ema25Price < lastOneBarClosePrice &&
                    ema25Price < lastTwoBarsClosePrice)
                {
                    result = true;
                    _logger.Debug("Can open ASC offer");
                    _logger.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}", ema25Price, lastOneBarClosePrice);
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (lastOneBarClosePrice> ema25Price && lastTwoBarsClosePrice<ema25Price && lastThreeBarPrice<ema25Price)
                {
                    result = true;
                   _logger.Debug("Can open DESC offer");
                   _logger.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}", ema25Price, lastOneBarClosePrice);
                }
            }

            return result;
        }

        public void OpenOffer(TREND_TYPE trendType)
        {
            var point = this.Point();
            var accountBalance = this.AccountBalance();

            if (trendType == TREND_TYPE.ASC)
            {
                double ask = this.Ask();
                var takeProfit = ask + int.Parse(_config.TakeProfit)*point;
                var stopLoss = ask - int.Parse(_config.StopLoss)*point;
                var result = this.OrderSend(_config.Symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 3,
                                            stopLoss, takeProfit);
                _logger.DebugFormat("Open buy offer. Ask price={0}, StopLoss={1}, TakeProfit={2}", ask, stopLoss, takeProfit);

                if (result == -1)
                {
                    this.OrderSend(_config.Symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 3,
                                   stopLoss, takeProfit);
                  _logger.DebugFormat("OpenOffer was sent second time");
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                double bid = this.Bid();
                var takeProfit = bid - int.Parse(_config.TakeProfit)*point;
                var stopLoss = bid + int.Parse(_config.StopLoss)*point;
                var result = this.OrderSend(_config.Symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid,
                                            3, stopLoss, takeProfit);
                _logger.DebugFormat("Open sell offer. Bid price={0}, StopLoss={1}, TakeProfit={2}", bid, stopLoss, takeProfit);

                if (result == -1)
                {
                    this.OrderSend(_config.Symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid, 3,
                                   stopLoss, takeProfit);
                  _logger.DebugFormat("OpenOffer was sent second time");
                }
            }
            var expertDetailRecord = new ExpertDetails
                {
                    State = State.Active,
                    CreatedOn = DateTime.Now,
                    Pair = GetCurrentSymbol(),
                    TimeFrame = GetCurrentTimeFrame(),
                    TrendType = trendType,
                    BalanceOnCreate = accountBalance,
                    ExpertName = GetType().ToString()
                };
            ExpertDetailsRepository.Save(expertDetailRecord);
            _logger.DebugFormat("New expertDetail Record was added. Id={0}", expertDetailRecord.Id);
        }
    }
}

