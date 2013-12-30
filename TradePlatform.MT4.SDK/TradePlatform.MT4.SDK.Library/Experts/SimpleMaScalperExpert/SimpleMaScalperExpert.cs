using System;
using System.Configuration;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;
using TradePlatform.MT4.SDK.Library.Config;

namespace TradePlatform.MT4.SDK.Library.Experts.SimpleMaScalperExpert
{
    public abstract class SimpleMaScalperExpert : CustomExpertAdvisor
    {
        protected override TREND_TYPE GetTrendType()
        {
            var result = TREND_TYPE.OTHER;
            var timeFrame = GetCurrentTimeFrame();
            var sma200M5Price = TechnicalIndicatiorsWrapper.iMA(this, _symbol, timeFrame, 200, 0, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var askPrice = PredefinedVariablesWrapper.Ask(this);
            var bidPrice = PredefinedVariablesWrapper.Bid(this);

            if (askPrice >= sma200M5Price && bidPrice >= sma200M5Price)
            {
                result = TREND_TYPE.ASC;
            }

            if (askPrice <= sma200M5Price && bidPrice <= sma200M5Price)
            {
                result = TREND_TYPE.DESC;
            }

            var sma200H1Price = TechnicalIndicatiorsWrapper.iMA(this, _symbol, TIME_FRAME.PERIOD_H1, 200, 0, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);
            if (askPrice >= sma200H1Price && bidPrice >= sma200H1Price && result == TREND_TYPE.ASC)
            {
                result = TREND_TYPE.ASC;
            }

            if (askPrice <= sma200H1Price && bidPrice <= sma200H1Price && result == TREND_TYPE.DESC)
            {
                result = TREND_TYPE.DESC;
            }

            if (result == TREND_TYPE.OTHER)
            {
                throw new Exception("Problem with declaring trend type");
            }
            return result;
        }

        protected override bool CanOpenOffer(TREND_TYPE trendType)
        {
            var result = false;
            var timeFrame = GetCurrentTimeFrame();
            var sma200Price = TechnicalIndicatiorsWrapper.iMA(this, _symbol, timeFrame, 200, 0, MA_METHOD.MODE_SMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var lastTwoBarsClosePrice = PredefinedVariablesWrapper.Close(this, 2);
            var lastOneBarClosePrice = PredefinedVariablesWrapper.Close(this, 1);
            var lastThreeBarPrice = PredefinedVariablesWrapper.Close(this, 3);

            if (trendType == TREND_TYPE.ASC)
            {
                if (sma200Price > lastThreeBarPrice && sma200Price < lastOneBarClosePrice && sma200Price < lastTwoBarsClosePrice)
                {
                    result = true;
                    Log.DebugFormat("Can open ASC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    Log.DebugFormat("Sma200Price={0}, LastClosedBarPrice={1}, lastTwoBarsClosePrice={2}, lastThreeBarsClosePrice={3}", sma200Price, lastOneBarClosePrice, lastTwoBarsClosePrice, lastThreeBarPrice);
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (lastThreeBarPrice > sma200Price && lastTwoBarsClosePrice < sma200Price && lastOneBarClosePrice < sma200Price)
                {
                    result = true;
                    Log.DebugFormat("Can open DESC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    Log.DebugFormat("Sma200Price={0}, LastClosedBarPrice={1}, lastTwoBarsClosePrice={2}, lastThreeBarsClosePrice={3}", sma200Price, lastOneBarClosePrice, lastTwoBarsClosePrice, lastThreeBarPrice);
                }
            }
            return result;
        }

        protected override void ReadConfigData()
        {
            var section = (ExpertConfiguration)ConfigurationManager.GetSection("ExpertConfiguration");
            _config = section.Experts["SimpleMaScalperExpert"];
        }
    }
}
