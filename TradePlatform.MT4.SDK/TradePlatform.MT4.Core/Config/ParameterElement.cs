using System.Configuration;

namespace TradePlatform.MT4.Core.Config
{
  public class ParameterElement : ConfigurationElement
  {
    [ConfigurationProperty("propertyName", IsKey = true, IsRequired = true)]
    public string PropertyName
    {
      get
      {
        return this["propertyName"] as string;
      }
      set
      {
        this["propertyName"] = (object) value;
      }
    }

    [ConfigurationProperty("propertyValue", IsKey = false, IsRequired = true)]
    public string PropertyValue
    {
      get
      {
        return this["propertyValue"] as string;
      }
      set
      {
        this["propertyValue"] = (object) value;
      }
    }
  }
}
