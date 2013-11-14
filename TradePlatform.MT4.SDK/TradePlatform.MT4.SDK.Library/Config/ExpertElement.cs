using System.Configuration;

namespace TradePlatform.MT4.SDK.Library.Config
{
    public class ExpertElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return base["name"] as string; }
            set { base["name"] = value; }
        }

        [ConfigurationProperty("stopLoss", IsRequired = true, IsKey = true)]
        public string StopLoss
        {
            get { return base["stopLoss"] as string; }
            set { base["stopLoss"] = value; }
        }

        [ConfigurationProperty("takeProfit", IsRequired = true, IsKey = true)]
        public string TakeProfit
        {
            get { return base["takeProfit"] as string; }
            set { base["takeProfit"] = value; }
        }

        [ConfigurationProperty("orderAmount", IsRequired = true, IsKey = true)]
        public string OrderAmount
        {
            get { return base["orderAmount"] as string; }
            set { base["orderAmount"] = value; }
        }

        [ConfigurationProperty("symbol", IsRequired = true, IsKey = true)]
        public string Symbol
        {
            get { return base["symbol"] as string; }
            set { base["symbol"] = value; }
        }

        [ConfigurationProperty("timeFrame", IsRequired = true, IsKey = true)]
        public string TimeFrame
        {
            get { return base["timeFrame"] as string; }
            set { base["timeFrame"] = value; }
        }
    }
}
