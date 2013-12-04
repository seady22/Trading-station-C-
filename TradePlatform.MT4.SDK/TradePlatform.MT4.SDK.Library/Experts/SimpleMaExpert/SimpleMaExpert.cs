using System.Configuration;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.Library.Config;

namespace TradePlatform.MT4.SDK.Library.Experts.SimpleMaExpert
{
    public abstract class SimpleMaExpert : CustomExpertAdvisor
    {
       protected override TREND_TYPE GetTrendType()
        {
            var result = TREND_TYPE.OTHER;
            var timeFrame = GetCurrentTimeFrame();
            var sma21Price = TechnicalIndicatiorsWrapper.Value.iMA(this,_symbol, timeFrame, 21, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var sma70Price = TechnicalIndicatiorsWrapper.Value.iMA(this,_symbol, timeFrame, 70, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);

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
            
            var sma21Price = TechnicalIndicatiorsWrapper.Value.iMA(this,_symbol, timeFrame, 21, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var sma70Price = TechnicalIndicatiorsWrapper.Value.iMA(this,_symbol, timeFrame, 70, 8, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);

            var lastTwoBarsClosePrice = PredefinedVariablesWrapper.Value.Close(this,2);
            var lastOneBarClosePrice = PredefinedVariablesWrapper.Value.Close(this,1);
            var lastThreeBarPrice = PredefinedVariablesWrapper.Value.Close(this,3);

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

        protected override void ReadConfigData()
        {
            var section = (ExpertConfiguration)ConfigurationManager.GetSection("ExpertConfiguration");
            _config = section.Experts["SimpleMaExpert"];
        }
    }
}
