using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.API.Wrappers;
using TradePlatform.MT4.SDK.Library.Handlers;
using log4net;

namespace TradePlatform.MT4.SDK.Library.Experts
{
    public class SimpleMovingAverageExpert : ExtendedExpertAdvisor
    {
        private static readonly ILog _log = LogManager.GetLogger(Assembly.GetAssembly(typeof(SimpleMovingAverageExpert)), typeof(SimpleMovingAverageExpert));

        public IRepository<ExpertDetails> ExpertDetailsRepository { get; set; }
        public TradingFunctionWrapper TradingFunctionWrapper { get; set; }
        public AccountInformationWrapper AccountInformationWrapper { get; set; }
        public TechnicalIndicatorsWrapper TechnicalIndicatorsWrapper { get; set; }
        public PredefinedVariablesWrapper PredefinedVariablesWrapper { get; set; }

        private SymbolsEnum _currentSymbol = SymbolsEnum.EURUSD; // only for first time
        private TIME_FRAME _currentTimeFrame = (TIME_FRAME)Enum.Parse(typeof(TIME_FRAME), ConfigurationManager.AppSettings["SimpleMovingAverage_TimeFramePeriod"]);

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
            _log.DebugFormat("Start execute expert logic");
            if (!IsOrdersOpen())
            {
                var trendType = GetTrendType();
                if (CanOpenOffer(trendType))
                {
                    
                }

            }
            else
            {
                _log.DebugFormat("There is open orders. Expert will wait while all orders will be closed");
            }
            return 1;
        }

        private bool IsOrdersOpen()
        {
            var ordersTotal = TradingFunctionWrapper.OrdersTotal(this);
            var ordersInDb = ExpertDetailsRepository.GetAll().Where(t => t.ClosedOn == null).ToList();
            _log.DebugFormat("Total opened Orders={0}. Opened orders in db={1}", ordersTotal, ordersInDb.Count());
            
            if (ordersTotal > 0)
            {
                if (ordersInDb.Any())
                {
                    var currentOrder = ordersInDb.Single();
                    currentOrder.ClosedOn = DateTime.Now;
                    currentOrder.BalanceOnClose = AccountInformationWrapper.AccountBalance(this);

                    ExpertDetailsRepository.Update(currentOrder);
                    _log.DebugFormat("Order in db was updated. Id={0}, ClosedOn={1}, BalanceOnClose={2}", currentOrder.Id, currentOrder.ClosedOn, currentOrder.BalanceOnClose);
                }
                return true;
            }
            return false;
        }

        private TREND_TYPE GetTrendType()
        {
            var result = TREND_TYPE.OTHER;
            
            var sma21Price = TechnicalIndicatorsWrapper.iMA(this, _currentSymbol.ToString(), _currentTimeFrame, 21, 8, MA_METHOD.MODE_SMA,
                                           APPLY_PRICE.PRICE_CLOSE, 0);
            _log.DebugFormat("Sma 21 Price={0}", sma21Price);

            var sma70Price = TechnicalIndicatorsWrapper.iMA(this, _currentSymbol.ToString(), _currentTimeFrame, 70, 8, MA_METHOD.MODE_SMA,
                                           APPLY_PRICE.PRICE_CLOSE, 0);
            _log.DebugFormat("Sma 70 Price={0}", sma70Price);
            if (sma21Price > sma70Price)
            {
                result = TREND_TYPE.ASC;
            }
            if (sma21Price < sma70Price)
            {
                result = TREND_TYPE.DESC;
            }
            _log.DebugFormat("Current Trend = {0}", result);
            return result;
        }

        private bool CanOpenOffer(TREND_TYPE trendType)
        {
            var result = false;
            var lastBarClosePrice = PredefinedVariablesWrapper.Close(this, 0);
            _log.DebugFormat("Last Bar ClosedPrice = {0}", lastBarClosePrice);

            var lastTwoBarsClosePrice = PredefinedVariablesWrapper.Close(this, 2);
            _log.DebugFormat("Last Two Bars ClosedPrice={0}", lastTwoBarsClosePrice);

            var lastOneBarClosePrice = PredefinedVariablesWrapper.Close(this, 1);
            _log.DebugFormat("Last One Bar ClosedPrice={0}", lastOneBarClosePrice);
            var sma21Price = TechnicalIndicatorsWrapper.iMA(this, _currentSymbol.ToString(), _currentTimeFrame, 21, 8, MA_METHOD.MODE_SMA,
                                                                APPLY_PRICE.PRICE_CLOSE, 0);
             var sma70Price = TechnicalIndicatorsWrapper.iMA(this, _currentSymbol.ToString(), _currentTimeFrame, 70, 8, MA_METHOD.MODE_SMA,
                                           APPLY_PRICE.PRICE_CLOSE, 0);

            if (trendType == TREND_TYPE.ASC)
            {
                if (lastBarClosePrice > sma70Price && lastTwoBarsClosePrice > sma70Price &&
                    lastOneBarClosePrice > sma70Price)
                {
                    if (lastOneBarClosePrice < sma21Price && lastTwoBarsClosePrice < sma21Price &&
                    lastBarClosePrice > sma21Price)
                    {
                        _log.DebugFormat("Order can be opened for buy");
                        result = true;
                    }
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                
            }
            return result;
        }
    }
}
