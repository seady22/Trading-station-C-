using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.Db.Extensions;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.Library.Handlers;

namespace TradePlatform.MT4.SDK.Library.Experts
{


    public class MACrossExpert : ExtendedExpertAdvisor
    {
        bool fastUnderSlow = false;

        protected override int Init()
        {
            return 1;
        }

        protected override int Start()
        {
            var repo = new Repository<LineBalanceAdvisorDetails>();
            var addedOrders = repo.GetBalanceAdvisorDetailsByState(State.Created);
            var currentTrend = TREND_TYPE.OTHER;

            var ordersTotal = this.OrdersTotal();
            if (ordersTotal != 0)
            {
                if (addedOrders.Count == 1)
                {
                    // update info about order
                }
                return 1;
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

