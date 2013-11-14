using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
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

        private static readonly ILog _log = LogManager.GetLogger(Assembly.GetAssembly(typeof (LineBalanceAdvisor)),
                                                                 typeof (LineBalanceAdvisor));

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
                var trendType = GetTrendType();
                if (CanOpenOffer(trendType))
                {
                    OpenOffer(trendType);
                }
            }
            else
            {
                _log.DebugFormat("There is open orders. Expert will wait while all orders will be closed");
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
            var ordersInDb = ExpertDetailsRepository.GetAll().Where(t => t.ClosedOn == null).ToList();
            _log.DebugFormat("Total opened Orders={0}. Opened orders in db={1}", ordersTotal, ordersInDb.Count());

            if (ordersTotal > 0)
            {
                if (ordersInDb.Any())
                {
                    var currentOrder = ordersInDb.Single();
                    currentOrder.ClosedOn = DateTime.Now;
                    currentOrder.BalanceOnClose = this.AccountBalance();
                    currentOrder.State = State.Closed;

                    ExpertDetailsRepository.Update(currentOrder);
                    _log.DebugFormat("Order in db was updated. Id={0}, ClosedOn={1}, BalanceOnClose={2}",
                                     currentOrder.Id, currentOrder.ClosedOn, currentOrder.BalanceOnClose);
                }
                return true;
            }
            return false;
        }

        private TREND_TYPE GetTrendType()
        {
            var result = TREND_TYPE.OTHER;
            var timeFrame = GetCurrentTimeFrame();
            var ema25Price = this.iMA(_config.Symbol, timeFrame, 25, 8, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var askPrice = this.Ask();
            var bidPrice = this.Bid();

            if (askPrice > ema25Price && bidPrice > ema25Price)
            {
                result = TREND_TYPE.ASC;
            }

            if (askPrice < ema25Price && bidPrice < ema25Price)
            {
                result = TREND_TYPE.DESC;
            }
            _log.DebugFormat("TrendType={0}", result);
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
                    _log.DebugFormat("Ready to open ASC offer");
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (lastOneBarClosePrice> ema25Price && lastTwoBarsClosePrice<ema25Price && lastThreeBarPrice<ema25Price)
                {
                    result = true;
                    _log.DebugFormat("Ready to open DESC offer");
                }
            }

            _log.DebugFormat("Can open offer={0}", result);

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

                if (result == -1)
                {
                    _log.DebugFormat("First order send attempt return -1. Another try");
                    this.OrderSend(_config.Symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), ask, 3,
                                   stopLoss, takeProfit);
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                double bid = this.Bid();
                var takeProfit = bid - int.Parse(_config.TakeProfit)*point;
                var stopLoss = bid + int.Parse(_config.StopLoss)*point;
                var result = this.OrderSend(_config.Symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid,
                                            3, stopLoss, takeProfit);
                                            

                if (result == -1)
                {
                    _log.DebugFormat("First order send attempt return -1. Another try");
                    this.OrderSend(_config.Symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid, 3,
                                   stopLoss, takeProfit);
                }
            }


            var expertDetailRecord = new ExpertDetails
                {
                    State = State.Active,
                    CreatedOn = DateTime.Now,
                    Pair = GetCurrentSymbol(),
                    TimeFrame = GetCurrentTimeFrame(),
                    TrendType = trendType,
                    BalanceOnCreate = accountBalance
                };
            ExpertDetailsRepository.Save(expertDetailRecord);
            _log.DebugFormat("Expert detail record was added. TrendType={0}, Symbol={1}, Pair={2}, Balance={3}, CreatedOn={4}", trendType, _config.Symbol, expertDetailRecord.Pair, expertDetailRecord.BalanceOnCreate, expertDetailRecord.CreatedOn);
        }
    }
}

