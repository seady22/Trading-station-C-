using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;

namespace TradePlatform.MT4.SDK.Library.Experts.SimpleMaExpert
{
    public abstract class SimpleMaExpert : CustomExpertAdvisor
    {
       protected override TREND_TYPE GetTrendType()
        {
            var result = TREND_TYPE.OTHER;
            var timeFrame = GetCurrentTimeFrame();
            var sma21Price = this.iMA(_symbol, timeFrame, 21, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var sma70Price = this.iMA(_symbol, timeFrame, 70, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);

            if (sma21Price >= sma70Price)
            {
                result = TREND_TYPE.ASC;
            }

            if (sma21Price <= sma70Price)
            {
                result = TREND_TYPE.DESC;
            }
           
            return result;
        }

        protected override bool CanOpenOffer(TREND_TYPE trendType)
        {
            var result = false;
            var timeFrame = GetCurrentTimeFrame();
            
            var sma21Price = this.iMA(_symbol, timeFrame, 21, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var sma70Price = this.iMA(_symbol, timeFrame, 70, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);

            var lastTwoBarsClosePrice = this.Close(2);
            var lastOneBarClosePrice = this.Close(1);
            var lastThreeBarPrice = this.Close(3);

            if (trendType == TREND_TYPE.ASC)
            {
                if (lastThreeBarPrice<sma21Price && lastThreeBarPrice > sma70Price && lastTwoBarsClosePrice > sma21Price && lastOneBarClosePrice > sma21Price)
                {
                    result = true;
                    _logger.DebugFormat("Can open ASC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    _logger.DebugFormat("Sma21Price={0}, Sma70Price={1}", sma21Price, sma70Price);
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (lastThreeBarPrice>sma21Price && lastThreeBarPrice < sma70Price && lastTwoBarsClosePrice < sma21Price && lastOneBarClosePrice < sma21Price)
                {
                     result = true;
                    _logger.DebugFormat("Can open DESC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                     _logger.DebugFormat("Sma21Price={0}, Sma70Price={1}", sma21Price, sma70Price);
                }
            }

            return result;
        }
    }
}
