using System;
using System.Linq;
using TradePlatform.MT4.SDK.API.Operations;
using TradePlatform.MT4.SDK.API.Wrappers;
using log4net;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.Library.Config;
using TradePlatform.MT4.SDK.Library.Handlers;

namespace TradePlatform.MT4.SDK.Library.Experts
{
    public abstract class CustomExpertAdvisor : ExtendedExpertAdvisor
    {
        public IRepository<ExpertDetails> ExpertDetailsRepository = new Repository<ExpertDetails>();
        public IRepository<ModifyOrderHistory> ModifyOrderRepository = new Repository<ModifyOrderHistory>();
 
        protected ExpertElement _config;
        protected string _symbol;

        protected ILog _generalLog = LogManager.GetLogger("GeneralLog");
        protected ILog _openOfferLog = LogManager.GetLogger("OpenOfferLogger");
        protected ILog _dbOperationsLog = LogManager.GetLogger("DbOperationsLogger");
        
        #region Wrapper Members

        protected AccountInformationWrapper AccoutInformationWrapper = new AccountInformationWrapper();
        protected CommonFunctionsWrapper CommonFunctionsWrapper = new CommonFunctionsWrapper();
        protected PredefinedVariabledWrapper PredefinedVariablesWrapper = new PredefinedVariabledWrapper();
        protected TechnicalIndicatorsWrapper TechnicalIndicatiorsWrapper = new TechnicalIndicatorsWrapper();
        protected TradingFunctionsWrapper TradingFunctionsWrapper = new TradingFunctionsWrapper();
        protected WindowsFunctionWrapper WindowsFunctionWrapper = new WindowsFunctionWrapper();  
       
        #endregion

        #region Operations 

        protected OrderOperations OrderOperations = new OrderOperations();
        #endregion

        protected override int Init()
        {
            return 1;
        }

        protected override int DeInit()
        {
            return 1;
        }

        protected override int Start()
        {
            GetSymbol();
            ReadConfigData();
            if (!IsOrderOpenForSymbol() && IsWorkDay())
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
            _symbol = WindowsFunctionWrapper.Symbol(this);
        }

        private bool IsOrderOpenForSymbol()
        {
            var result = false;
            var expertAdvisorRecord =
                ExpertDetailsRepository.GetAll().FirstOrDefault(x => x.State == State.Active.ToString() && x.ExpertName == GetType().Name);
            if (expertAdvisorRecord != null)
            {
                result = true;
            }
           // var ordersTotal = TradingFunctionsWrapper.OrdersTotal(this);
            //for (int i = 0; i < ordersTotal; i++)
            //{
            //    var isOrderSelected = TradingFunctionsWrapper.OrderSelect(this, i, SELECT_BY.SELECT_BY_POS);
            //    if (isOrderSelected)
            //    {
            //        var orderCloseTime = TradingFunctionsWrapper.OrderCloseTime(this);
            //        if (orderCloseTime.Year == 1970)//order still open
            //        {
            //            var symbol = TradingFunctionsWrapper.OrderSymbol(this);
            //            if (symbol == _symbol)
            //            {
            //                result = true;
            //            }
            //        }
            //    }
            //}
            return result;
        }

        private bool IsWorkDay()
        {
            var currentDateTime = DateTime.Now;
            return (currentDateTime.DayOfWeek != DayOfWeek.Saturday || currentDateTime.DayOfWeek != DayOfWeek.Sunday) ;
        }

        private void UpdateOrdersInDb()
        {
            var orderInDb = ExpertDetailsRepository.GetAll().Where(x => x.ClosedOn == null && x.Pair == _symbol && x.ExpertName == GetType().Name).ToList();
            foreach (var openedOrder in orderInDb)
            {
                var ticketId = openedOrder.OrderId;
                if (TradingFunctionsWrapper.OrderSelect(this, ticketId, SELECT_BY.SELECT_BY_TICKET))
                {
                    var orderCloseTime = TradingFunctionsWrapper.OrderCloseTime(this);
                    if (orderCloseTime.Year != 1970)
                    {
                        openedOrder.ClosedOn = DateTime.Now;
                        openedOrder.BalanceOnClose = AccoutInformationWrapper.AccountEquity(this);
                        openedOrder.State = State.Closed.ToString();
                        openedOrder.Profit = 0;

                        if (TradingFunctionsWrapper.OrderSelect(this, openedOrder.OrderId, SELECT_BY.SELECT_BY_TICKET))
                        {
                            openedOrder.Profit = TradingFunctionsWrapper.OrderProfit(this);
                        }
                        ExpertDetailsRepository.Update(openedOrder);
                        _dbOperationsLog.DebugFormat("OrderId={0}. Order was updated. ClosedOn={1}, BalanceOnClosed={2}, State={3}, Profit={4}, Pair={5}", openedOrder.Id, openedOrder.ClosedOn, openedOrder.BalanceOnClose, openedOrder.State, openedOrder.Profit, openedOrder.Pair);
                    }
                }   
            }
        }

        protected TIME_FRAME GetCurrentTimeFrame()
        {
            var timeFrame = (TIME_FRAME)Enum.Parse(typeof(TIME_FRAME), _config.TimeFrame);
            return timeFrame;
        }

        public void OpenOffer(TREND_TYPE trendType)
        {
            var point = PredefinedVariablesWrapper.Point(this);
            var accountBalance = AccoutInformationWrapper.AccountEquity(this);
            var result = -1;

            double ask = PredefinedVariablesWrapper.Ask(this);
            double bid = PredefinedVariablesWrapper.Bid(this);

            if (trendType == TREND_TYPE.ASC)
            {
                var takeProfit = bid + int.Parse(_config.TakeProfit)*point;
                var stopLoss = bid - int.Parse(_config.StopLoss)*point;
                result = OrderOperations.OpenOffer(this, _symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 3, stopLoss, takeProfit);
            }

            if (trendType == TREND_TYPE.DESC)
            {
                var takeProfit = ask - int.Parse(_config.TakeProfit)*point;
                var stopLoss = ask + int.Parse(_config.StopLoss)*point;
                result = OrderOperations.OpenOffer(this, _symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid, 3, stopLoss, takeProfit);
            }

            if (result == -1)
            {
                return;
            }

            AddActiveExpertDetail(trendType, accountBalance, result);
        }

        private void AddActiveExpertDetail(TREND_TYPE trendType, double accountBalance, int result)
        {
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
            _dbOperationsLog.DebugFormat("New expertDetail Record was added. Id={0}. Pair={1}, TrendType={2}",
                                         expertDetailRecord.Id, expertDetailRecord.Pair, expertDetailRecord.TrendType);
        }

        abstract protected TREND_TYPE GetTrendType();
        abstract protected bool CanOpenOffer(TREND_TYPE trendType);
        abstract protected void ReadConfigData();
    }
}
