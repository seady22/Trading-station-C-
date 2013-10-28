using System;
using System.Linq;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.API.Wrappers;
using TradePlatform.MT4.SDK.Library.Handlers;

namespace TradePlatform.MT4.SDK.Library.Experts
{
    public class LineBalanceAdvisor : ExtendedExpertAdvisor
    {
        public TradingFunctionWrapper TradingFunctionWrapper { get; set; }
        public AccountInformationWrapper AccountInformationWrapper { get; set; }
        public PredefinedVariablesWrapper PredefinedVariablesWrapper { get; set; }
        public TechnicalIndicatorsWrapper TechnicalIndicatorsWrapper { get; set; }
        public CommonFunctionsWrapper CommonFunctionsWrapper { get; set; }
        public Repository<LineBalanceAdvisorDetails> LineBalanceAdvisorDetailsRepository { get; set; }

        protected override int Init()
        {
            return 1;
        }

        protected override int Start()
        {
            var currentTrend = TREND_TYPE.OTHER;
            var createdOrder = LineBalanceAdvisorDetailsRepository.Items.SingleOrDefault(x => x.State == State.Created && x.ActivedOn == null);
            var ordersTotal = TradingFunctionWrapper.OrdersTotal(this);
            if (ordersTotal > 0)
            {
                if (createdOrder != null)
                {
                    createdOrder.State = State.Active;
                    createdOrder.ActivedOn = DateTime.UtcNow;
                    createdOrder.CurrentBalance = AccountInformationWrapper.AccountBalance(this);
                    LineBalanceAdvisorDetailsRepository.Update(createdOrder);
                }
                return 1;
            }

            if (ordersTotal == 0)
            {
                var item = LineBalanceAdvisorDetailsRepository.Items.SingleOrDefault(x => x.State == State.Active && x.ActivedOn != null);
                var accountBalance = AccountInformationWrapper.AccountBalance(this);
                if (item != null)
                {
                    item.UpdatedBalance = accountBalance;
                    item.State = State.Closed;
                    item.ClosedOn = DateTime.UtcNow;
                    LineBalanceAdvisorDetailsRepository.Update(item);
                }
                return 1;
            }

            var askPrice = PredefinedVariablesWrapper.Ask(this);
            var bidPrice = PredefinedVariablesWrapper.Bid(this);

            var movingPrice = TechnicalIndicatorsWrapper.iMA(this, "EURUSD", TIME_FRAME.PERIOD_H4, 25, 0, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            if (askPrice < movingPrice && bidPrice < movingPrice)
            {
                currentTrend = TREND_TYPE.DESC;
            }

            if (askPrice > movingPrice && bidPrice > movingPrice)
            {
                currentTrend = TREND_TYPE.ASC;
            }

            var lastBarClosePrice = PredefinedVariablesWrapper.Close(this, 1);
            var lastBarOpenPrice = PredefinedVariablesWrapper.Open(this, 1);

            if (currentTrend == TREND_TYPE.ASC)
            {
                    if (movingPrice >= lastBarOpenPrice && movingPrice <= lastBarClosePrice)
                    {
                        var point = CommonFunctionsWrapper.MarketInfo(this, "EURUSD", MARKER_INFO_MODE.MODE_POINT);
                        var orderSendResult = TradingFunctionWrapper.OrderSend(this, "EURUSD", ORDER_TYPE.OP_BUYSTOP, 0.01, askPrice, 1,
                                                         askPrice - 30*point, askPrice + 50*point, "LineBalanceExpert",
                                                         0, DateTime.UtcNow.AddDays(1));
                        if (orderSendResult > 0)
                        {
                            var accountBalance = AccountInformationWrapper.AccountBalance(this);
                            var lineBalanceAdvisorItem = new LineBalanceAdvisorDetails
                            {
                                CreatedOn = DateTime.UtcNow,
                                State = State.Created,
                                TimeFrame = TimeFrame.H4,
                                Pair = Pair.EURUSD,
                                CurrentBalance = accountBalance,
                                TrendType = "ASC"
                            };
                            LineBalanceAdvisorDetailsRepository.Insert(lineBalanceAdvisorItem);
                        }
                        
                    }
            }

            if (currentTrend == TREND_TYPE.DESC)
            {
                    if (movingPrice <= lastBarOpenPrice && movingPrice >= lastBarClosePrice)
                    {
                        var point = CommonFunctionsWrapper.MarketInfo(this, "EURUSD", MARKER_INFO_MODE.MODE_POINT);
                        var orderSendResult = TradingFunctionWrapper.OrderSend(this, "EURUSD", ORDER_TYPE.OP_SELLSTOP, 0.01, askPrice, 1,
                                                          bidPrice + 30 * point, bidPrice - 50 * point, "LineBalanceExpert",
                                                          0, DateTime.UtcNow.AddDays(1));
                        var accountBalance = AccountInformationWrapper.AccountBalance(this);
                        var lineBalanceAdvisorItem = new LineBalanceAdvisorDetails
                        {
                            CreatedOn = DateTime.UtcNow,
                            State = State.Created,
                            TimeFrame = TimeFrame.H4,
                            Pair = Pair.EURUSD,
                            CurrentBalance = accountBalance,
                            TrendType = "DESC"
                        };
                        LineBalanceAdvisorDetailsRepository.Insert(lineBalanceAdvisorItem);
                    }
            }
            return 1;
        }

        protected override int DeInit()
        {
            return 1;
        }
    }
}

