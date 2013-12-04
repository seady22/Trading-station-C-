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
            var ema25Price = this.iMA(base._symbol, timeFrame, 25, 8, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var askPrice = this.Ask();
            var bidPrice = this.Bid();

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
            var ema25Price = this.iMA(_symbol, timeFrame, 25, 8, MA_METHOD.MODE_EMA, APPLY_PRICE.PRICE_CLOSE, 0);
            var lastTwoBarsClosePrice = this.Close(2);
            var lastOneBarClosePrice = this.Close(1);
            var lastThreeBarPrice = this.Close(3);

            if (trendType == TREND_TYPE.ASC)
            {
                if (ema25Price > lastThreeBarPrice && ema25Price < lastOneBarClosePrice &&
                    ema25Price < lastTwoBarsClosePrice)
                {
                    result = true;
                    _logger.DebugFormat("Can open ASC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                    _logger.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}", ema25Price, lastOneBarClosePrice);
                }
            }

            if (trendType == TREND_TYPE.DESC)
            {
                if (lastThreeBarPrice > ema25Price && lastTwoBarsClosePrice<ema25Price && lastOneBarClosePrice<ema25Price)
                {
                    result = true;
                    _logger.DebugFormat("Can open DESC offer. TrendType={0}, Symbol={1}", GetTrendType(), _symbol);
                   _logger.DebugFormat("Ema25Price={0}, LastClosedBarPrice={1}", ema25Price, lastOneBarClosePrice);
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

