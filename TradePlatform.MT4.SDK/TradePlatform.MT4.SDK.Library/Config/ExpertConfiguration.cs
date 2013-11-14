using System.Configuration;

namespace TradePlatform.MT4.SDK.Library.Config
{
    public class ExpertConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("Experts")]
        public ExpertElementCollection Experts
        {
            get { return base["Experts"] as ExpertElementCollection; }
        }

    }
}
