using System.Configuration;

namespace TradePlatform.MT4.Db.Config
{
    public class DbConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("ConnectionString")]
        public DbConnectionStringElement ConnectionStringElement
        {
            get { return base["ConnectionString"] as DbConnectionStringElement; }
        }
    }
}
