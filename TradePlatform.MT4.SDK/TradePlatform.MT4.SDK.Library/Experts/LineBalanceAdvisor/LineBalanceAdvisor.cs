using System;
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
            var ema25Price = TechnicalIndicatiorsWrapper.iMA(this, _symbol, timeFrame, 25, 8, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
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
            var ema25Price = TechnicalIndicatiorsWrapper.iMA(this,_symbol, timeFrame, 25, 8, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var lastTwoBarsClosePrice = PredefinedVariablesWrapper.Close(this,2);
            var lastOneBarClosePrice = PredefinedVariablesWrapper.Close(this,1);
            var lastThreeBarPrice = PredefinedVariablesWrapper.Close(this,3);

            if (trendType == TREND_TYPE.ASC)
            {
                if (ema25Price > lastThreeBarPrice && ema25Price < lastOneBarClosePrice && ema25Price < lastTwoBarsClosePrice)
                   
                {
                    result = true;
                    _openOfferLog.DebugFormat("Can open ASC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    _openOfferLog.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}, lastTwoBarsClosePrice={2}, lastThreeBarsClosePrice={3}", ema25Price, lastOneBarClosePrice, lastTwoBarsClosePrice, lastThreeBarPrice);
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (lastThreeBarPrice > ema25Price && lastTwoBarsClosePrice<ema25Price && lastOneBarClosePrice<ema25Price)
                {
                    result = true;
                    _openOfferLog.DebugFormat("Can open DESC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    _openOfferLog.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}, lastTwoBarsClosePrice={2}, lastThreeBarsClosePrice={3}", ema25Price, lastOneBarClosePrice, lastTwoBarsClosePrice, lastThreeBarPrice);
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

