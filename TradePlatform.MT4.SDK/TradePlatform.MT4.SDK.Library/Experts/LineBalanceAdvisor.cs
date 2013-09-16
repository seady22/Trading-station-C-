using System.Linq;
using Autofac;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.Db.Extensions;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.API.DI;
using TradePlatform.MT4.SDK.API.Wrappers;
using TradePlatform.MT4.SDK.Library.Handlers;

namespace TradePlatform.MT4.SDK.Library.Experts
{
    public class LineBalanceAdvisor : ExtendedExpertAdvisor
    {
        public TradingFunctionWrapper TradingFunctionWrapper { get; set; }
        public Repository<LineBalanceAdvisorDetails> LineBalanceAdvisorDetails { get; set; }

        protected override int Init()
        {
            return 1;
        }

        public LineBalanceAdvisor()
        {
            Container.GetInstance().InjectProperties(this);
        }

        protected override int Start()
        {
            var addedOrders = LineBalanceAdvisorDetails.GetBalanceAdvisorDetailsByState(State.Created);
            var currentTrend = TREND_TYPE.OTHER;

            var ordersTotal = TradingFunctionWrapper.OrdersTotal(this);
            if (ordersTotal != 0)
            {
                if (addedOrders.Count == 1)
                {
                    var item = LineBalanceAdvisorDetails.Items.Where(x => x.State == State.Created).Single();
                    if (item != null)
                    {
                        item.State = State.Active;
                        LineBalanceAdvisorDetails.Update(item);
                    }
                }
                return 1;
            }

            if (ordersTotal == 0)
            {
                var item = LineBalanceAdvisorDetails.Items.Where(x => x.State == State.Active).SingleOrDefault();
                if (item != null)
                {
                    var accountBalance = this.AccountBalance();
                    item.UpdatedBalance = accountBalance;
                    LineBalanceAdvisorDetails.Update(item);
                }
            }

            var askPrice = PredefinedVariables.Ask(this);
            var bidPrice = PredefinedVariables.Bid(this);
            var movingPrice = TechnicalIndicators.iMA(this, "EURUSD", TIME_FRAME.PERIOD_H4, 25, 0, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            if (askPrice < movingPrice && bidPrice < movingPrice)
            {
                currentTrend = TREND_TYPE.DESC;
            }

            if (askPrice > movingPrice && bidPrice > movingPrice)
            {
                currentTrend = TREND_TYPE.ASC;
            }
                                    
            var lastBarClosePrice = PredefinedVariables.Close(this, 1);
            var lastBarOpenPrice = PredefinedVariables.Open(this, 1);

            if (currentTrend == TREND_TYPE.ASC)
            {
                    if (movingPrice >= lastBarOpenPrice && movingPrice <= lastBarClosePrice)
                    {
                        // create buy stop
                        //logging that order was added to db.
                    }
            }

            if (currentTrend == TREND_TYPE.DESC)
            {
                    if (movingPrice <= lastBarOpenPrice && movingPrice >= lastBarClosePrice)
                    {
                        // create sell stop
                        //logging that order was added to db.
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

