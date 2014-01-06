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

        protected ILog Log = LogManager.GetLogger("ExpertsLogger");
        private ILog _mt4Log = LogManager.GetLogger(typeof (CustomExpertAdvisor));
        
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

            if (IsOrderOpenForSymbol() && IsWorkDay())
            {
                
                foreach (var openOffer in ExpertDetailsRepository.GetAll().Where(x => x.ClosedOn == null && x.Pair == _symbol && x.ExpertName == GetType().Name).ToList())
                {
                    var isOrderSelected = TradingFunctionsWrapper.OrderSelect(this, openOffer.OrderId, SELECT_BY.SELECT_BY_TICKET);
                    if (isOrderSelected)
                    {
                       TryToModifyOrder(openOffer);
                    }
                    else
                    {
                        var errorMessage = CallMqlMethod("GetLastError", null);
                        Log.DebugFormat("Order was not selected. OrderId={0}, ErrorMessage={1}", openOffer.OrderId, errorMessage);                
                    }
                }
            }
            return 1;
        }

        private void TryToModifyOrder(ExpertDetails openOffer)
        {
            var point = PredefinedVariablesWrapper.Point(this);
            var trendType = openOffer.TrendType;
            var orderOpenPrice = TradingFunctionsWrapper.OrderOpenPrice(this);
            var orderStopLoss = TradingFunctionsWrapper.OrderStopLoss(this);
            var orderTakeProfit = TradingFunctionsWrapper.OrderTakeProfit(this);
            
            if (trendType == "ASC")
            {
                var bidPrice = PredefinedVariablesWrapper.Bid(this);
                var takeProfitPriceWith5PointsDifference = bidPrice + (int.Parse(_config.TakeProfit) - 5)*point;
                if (bidPrice >= takeProfitPriceWith5PointsDifference)
                {
                    Log.DebugFormat("Time to modify Order. Symbol={0}, TrendType={1}, BidPrice={2}, TakeProfitPriceWith5PointsDifference = {3}",
                                    openOffer.Pair, openOffer.TrendType, bidPrice, takeProfitPriceWith5PointsDifference);
                       
                    var updatedStopLoss = orderStopLoss - int.Parse(_config.StopLoss) * point;
                    var updatedTakeProfit = orderTakeProfit + int.Parse(_config.TakeProfit) * point;
                    var modifyOrderResult = OrderOperations.ModifyOffer(this, openOffer.OrderId, orderOpenPrice, updatedStopLoss, updatedTakeProfit);
                    
                    if (!modifyOrderResult)
                    {
                        Log.DebugFormat("ModifyOrder was not executed.");
                        var errorMessage = this.CallMqlMethod("GetLastError", null);
                        Log.DebugFormat("ModifyOrder error = {0}", errorMessage);
                    }

                    if (modifyOrderResult)
                    {
                        LogModifyOrderAttempt(openOffer.OrderId, updatedStopLoss, updatedTakeProfit);
                    }
                }
            }

            if (trendType == "DESC")
            {
                var askPrice = PredefinedVariablesWrapper.Ask(this);
                var takeProfitPriceWith5PointsDifference = askPrice - (int.Parse(_config.TakeProfit) - 5)*point;
                if (askPrice <= takeProfitPriceWith5PointsDifference)
                {
                    Log.DebugFormat("Time to modify Order. Symbol={0}, TrendType={1}, AskPrice={2}, takeProfitPriceWith5PointsDifference = {3}", openOffer.Pair, openOffer.TrendType, askPrice, takeProfitPriceWith5PointsDifference);
                    var updatedStopLoss = orderStopLoss + int.Parse(_config.StopLoss)*point;
                    var updatedTakeProfit = orderTakeProfit - int.Parse(_config.TakeProfit)*point;
                    var modifyOrderResult = OrderOperations.ModifyOffer(this, openOffer.OrderId, orderOpenPrice,
                                                                        updatedStopLoss,
                                                                        updatedTakeProfit);
                    if (!modifyOrderResult)
                    {
                        Log.DebugFormat("ModifyOrder was not executed.");
                        var errorMessage = this.CallMqlMethod("GetLastError", null);
                        Log.DebugFormat("ModifyOrder error = {0}", errorMessage);
                    }

                    if (modifyOrderResult)
                    {
                        LogModifyOrderAttempt(openOffer.OrderId, updatedStopLoss, updatedTakeProfit);
                    }
                }
            }
        }

        private void LogModifyOrderAttempt(int orderId, double stopLoss, double takeProfit)
        {
            var modifyOrderHistoryRecord = new ModifyOrderHistory
            {
                CreatedOn = DateTime.UtcNow,
                OrderId = orderId,
                UpdatedStopLoss = stopLoss,
                UpdatedTakeProfit = takeProfit
            };
            ModifyOrderRepository.Save(modifyOrderHistoryRecord);
            Log.DebugFormat("ModifyOrderHistory record was added. OrderId={0}, UpdatedStopLoss={1}, UpdatedTakeProfit={2}, Symbol={3}", orderId, stopLoss, takeProfit, _symbol);
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
           var isOrderSelected = TradingFunctionsWrapper.OrderSelect(this, expertAdvisorRecord.OrderId, SELECT_BY.SELECT_BY_TICKET);
           if (isOrderSelected)
           {
               var orderCloseTime = TradingFunctionsWrapper.OrderCloseTime(this);
               if (orderCloseTime.Year == 1970)//order still open
               {
                   var symbol = TradingFunctionsWrapper.OrderSymbol(this);
                   if (symbol == _symbol)
                   {
                       result = true;
                   }
               }
           }
       }
       _mt4Log.DebugFormat("IsOrderOpenForSymbol returned = {0}. Symbol={1}", result, _symbol);
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
                        Log.DebugFormat("OrderId={0}. Order was updated. ClosedOn={1}, BalanceOnClosed={2}, State={3}, Profit={4}, Pair={5}", openedOrder.Id, openedOrder.ClosedOn, openedOrder.BalanceOnClose, openedOrder.State, openedOrder.Profit, openedOrder.Pair);
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

            double stopLoss = 0;
            double takeProfit = 0;

            if (trendType == TREND_TYPE.ASC)
            {
                takeProfit = bid + int.Parse(_config.TakeProfit)*point;
                stopLoss = bid - int.Parse(_config.StopLoss)*point;
                result = OrderOperations.OpenOffer(this, _symbol, ORDER_TYPE.OP_BUY, double.Parse(_config.OrderAmount), ask, 0, stopLoss, takeProfit);
            }

            if (trendType == TREND_TYPE.DESC)
            {
                takeProfit = ask - int.Parse(_config.TakeProfit)*point;
                stopLoss = ask + int.Parse(_config.StopLoss)*point;
                result = OrderOperations.OpenOffer(this, _symbol, ORDER_TYPE.OP_SELL, double.Parse(_config.OrderAmount), bid, 0, stopLoss, takeProfit);
            }

            if (result == -1 || result == 1)
            {
                var error = CallMqlMethod("GetLastError", null);
                Log.DebugFormat("Order was not created. Error={0}", error);
                return;
            }

            Log.DebugFormat("Order was opened");
            AddActiveExpertDetail(trendType, accountBalance, result, stopLoss, takeProfit);
        }

        private void AddActiveExpertDetail(TREND_TYPE trendType, double accountBalance, int result, double stopLoss, double takeProfit)
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
                    OrderId = result,
                    StopLoss = stopLoss,
                    TakeProfit = takeProfit
                };
            ExpertDetailsRepository.Save(expertDetailRecord);
            Log.DebugFormat("New expertDetail Record was added. Id={0}. Pair={1}, TrendType={2}",
                                         expertDetailRecord.Id, expertDetailRecord.Pair, expertDetailRecord.TrendType);
        }

        abstract protected TREND_TYPE GetTrendType();
        abstract protected bool CanOpenOffer(TREND_TYPE trendType);
        abstract protected void ReadConfigData();
    }
}
