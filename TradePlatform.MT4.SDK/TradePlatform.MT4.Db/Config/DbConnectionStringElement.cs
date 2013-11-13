using System.Configuration;

namespace TradePlatform.MT4.Db.Config
{
    public class DbConnectionStringElement : ConfigurationElement
    {
        [ConfigurationProperty("server", IsRequired = true, IsKey = true)]
        public string Server
        {
            get { return base["server"] as string; }
            set { base["server"] = value; }
        }

        [ConfigurationProperty("database", IsRequired = true, IsKey = true)]
        public string DataBase
        {
            get { return base["database"] as string; }
            set { base["database"] = value; }
        }

        [ConfigurationProperty("username", IsRequired = true, IsKey = true)]
        public string Username
        {
            get { return base["username"] as string; }
            set { base["username"] = value; }
        }

        [ConfigurationProperty("pwd", IsRequired = true, IsKey = true)]
        public string Pwd
        {
            get { return base["pwd"] as string; }
            set { base["pwd"] = value; }
        }
    }
}
