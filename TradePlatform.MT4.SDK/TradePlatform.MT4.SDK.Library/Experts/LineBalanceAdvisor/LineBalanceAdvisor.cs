using System.Configuration;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.Library.Config;

namespace TradePlatform.MT4.SDK.Library.Experts.LineBalanceAdvisor
{
    public abstract class LineBalanceAdvisor : CustomExpertAdvisor
    {
        protected override TREND_TYPE GetTrendType()
        {
            var result = TREND_TYPE.OTHER;
            var timeFrame = GetCurrentTimeFrame();
            var ema25Price = TechnicalIndicatiorsWrapper.iMA(this, _symbol, timeFrame, 25, 0, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var askPrice = PredefinedVariablesWrapper.Ask(this);
            var bidPrice = PredefinedVariablesWrapper.Bid(this);

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

        protected override bool CanOpenOffer(TREND_TYPE trendType)
        {
            var result = false;
            var timeFrame = GetCurrentTimeFrame();
            var ema25Price = TechnicalIndicatiorsWrapper.iMA(this,_symbol, timeFrame, 25, 0, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var lastTwoBarsClosePrice = PredefinedVariablesWrapper.Close(this,2);
            var lastOneBarClosePrice = PredefinedVariablesWrapper.Close(this,1);

            if (trendType == TREND_TYPE.ASC)
            {
                if (ema25Price > lastTwoBarsClosePrice && ema25Price < lastOneBarClosePrice)
                   
                {
                    result = true;
                    Log.DebugFormat("Can open ASC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    Log.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}, lastTwoBarsClosePrice={2}", ema25Price, lastOneBarClosePrice, lastTwoBarsClosePrice);
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (lastTwoBarsClosePrice > ema25Price && lastOneBarClosePrice < ema25Price)
                {
                    result = true;
                    Log.DebugFormat("Can open DESC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    Log.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}, lastTwoBarsClosePrice={2}", ema25Price, lastOneBarClosePrice, lastTwoBarsClosePrice);
                }
            }

            if (!result)// try to check if bar was touched near MA
            {
                var lastOneBarHighPrice = PredefinedVariablesWrapper.High(this, 1);
                var lastOneBarLowPrice = PredefinedVariablesWrapper.Low(this, 1);
                if (trendType == TREND_TYPE.ASC)
                {
                    if (lastOneBarLowPrice == ema25Price ||(lastOneBarHighPrice > ema25Price && lastOneBarLowPrice < ema25Price) || (lastOneBarClosePrice == ema25Price))
                    {
                        result = true;
                        Log.DebugFormat("LastBar are on ema25 or near ema25. Can open ASC Offer");
                        Log.DebugFormat("Symbol={0}, Ema25Price={1},LastOneBarClosePrice={2}, TrendType={3}", _symbol, ema25Price, lastOneBarClosePrice, trendType);
                    }
                }

                if (trendType == TREND_TYPE.DESC)
                {
                    if (lastOneBarHighPrice == ema25Price || (lastOneBarLowPrice > ema25Price && lastOneBarHighPrice < ema25Price) || (lastOneBarClosePrice == ema25Price))
                    {
                        result = true;
                        Log.DebugFormat("LastBar are on ema25Price or near. Can open DESC Offer");
                        Log.DebugFormat("Symbol={0}, Ema25Price={1},LastOneBarClosePrice={2}, TrendType={3}", _symbol, ema25Price, lastOneBarClosePrice, trendType);
                    }
                }

                
            }
            return result;
        }

        protected override void ReadConfigData()
        {
             var section = (ExpertConfiguration)ConfigurationManager.GetSection("ExpertConfiguration");
            _config = section.Experts["LineBalanceAdvisor"];
        }
    }
}

