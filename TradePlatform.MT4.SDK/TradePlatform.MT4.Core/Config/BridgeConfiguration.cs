using System.Configuration;

namespace TradePlatform.MT4.Core.Config
{
  public class BridgeConfiguration : ConfigurationSection
  {
    [ConfigurationProperty("Hosts")]
    public HostElementCollection Hosts
    {
      get
      {
        return this["Hosts"] as HostElementCollection;
      }
    }

    [ConfigurationProperty("wcfBaseAddress", IsKey = true, IsRequired = true)]
    public string WcfBaseAddress
    {
      get
      {
        return (string) this["wcfBaseAddress"];
      }
      set
      {
        this["wcfBaseAddress"] = (object) value;
      }
    }
  }
}
