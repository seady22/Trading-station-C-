using System;
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
    public class LineBalanceAdvisor : ExtendedExpertAdvisor
    {
        public TradingFunctionWrapper TradingFunctionWrapper { get; set; }
        public AccountInformationWrapper AccountInformationWrapper { get; set; }
        public PredefinedVariablesWrapper PredefinedVariablesWrapper { get; set; }
        public TechnicalIndicatorsWrapper TechnicalIndicatorsWrapper { get; set; }
        public CommonFunctionsWrapper CommonFunctionsWrapper { get; set; }
        public IRepository<ExpertDetails> ExpertDetailsRepository { get; set; }

        private static readonly ILog _log = LogManager.GetLogger(Assembly.GetAssembly(typeof(LineBalanceAdvisor)), typeof(LineBalanceAdvisor));

        private SymbolsEnum _currentSymbol = SymbolsEnum.EURUSD; // only for first time

        protected override int Init()
        {
            return 1;
        }

        protected override int Start()
        {
            TradingFunctionWrapper = new TradingFunctionWrapper();
           AccountInformationWrapper = new AccountInformationWrapper();
            PredefinedVariablesWrapper = new PredefinedVariablesWrapper();
            TechnicalIndicatorsWrapper = new TechnicalIndicatorsWrapper();
            CommonFunctionsWrapper = new CommonFunctionsWrapper();
            ExpertDetailsRepository = new Repository<ExpertDetails>();
            if (!IsOrdersOpen())
            {
                var trendType = GetTrendType();
                if (CanOpenOffer(trendType))
                {
                   // OpenOffer(trendType);
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

            var ema25Price = TechnicalIndicatorsWrapper.iMA(this, _currentSymbol.ToString(), TIME_FRAME.PERIOD_H4, 25, 8, MA_METHOD.MODE_EMA,
                                           APPLY_PRICE.PRICE_CLOSE, 0);
            var askPrice = PredefinedVariablesWrapper.Ask(this);
            var bidPrice = PredefinedVariablesWrapper.Bid(this);

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

        private bool CanOpenOffer(TREND_TYPE trendType)
        {
            var result = false;
            var ema25Price = TechnicalIndicatorsWrapper.iMA(this, _currentSymbol.ToString(), TIME_FRAME.PERIOD_H4, 25, 8, MA_METHOD.MODE_EMA,
                                           APPLY_PRICE.PRICE_CLOSE, 0);

            var lastBarClosePrice = PredefinedVariablesWrapper.Close(this, 0);
            //_log.DebugFormat("Last Bar ClosedPrice = {0}", lastBarClosePrice);

            var lastTwoBarsClosePrice = PredefinedVariablesWrapper.Close(this, 2);
            //_log.DebugFormat("Last Two Bars ClosedPrice={0}", lastTwoBarsClosePrice);

            var lastOneBarClosePrice = PredefinedVariablesWrapper.Close(this, 1);
            //_log.DebugFormat("Last One Bar ClosedPrice={0}", lastOneBarClosePrice);

            if (trendType == TREND_TYPE.ASC)
            {
               if (ema25Price > lastTwoBarsClosePrice && ema25Price > lastOneBarClosePrice &&
                   lastBarClosePrice > ema25Price)
               {
                   result = true;
                   _log.DebugFormat("Ready to open ASC offer");
               }   
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (ema25Price < lastTwoBarsClosePrice && ema25Price < lastOneBarClosePrice &&
                   lastBarClosePrice < ema25Price)
                {
                    result = true;
                    _log.DebugFormat("Ready to open DESC offer");
                }   
            }

            _log.DebugFormat("Can open offer={0}", result);

            return result;
        }
    }
}

