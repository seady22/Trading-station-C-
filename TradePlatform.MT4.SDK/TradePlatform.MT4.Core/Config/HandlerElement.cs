using System.Configuration;

namespace TradePlatform.MT4.Core.Config
{
  public class HandlerElement : ConfigurationElement
  {
    [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
    public string Name
    {
      get
      {
        return this["name"] as string;
      }
      set
      {
        this["name"] = (object) value;
      }
    }

    [ConfigurationProperty("typeName", IsKey = false, IsRequired = true)]
    public string TypeName
    {
      get
      {
        return this["typeName"] as string;
      }
      set
      {
        this["typeName"] = (object) value;
      }
    }

    [ConfigurationProperty("assemblyName", IsKey = false, IsRequired = true)]
    public string AssemblyName
    {
      get
      {
        return this["assemblyName"] as string;
      }
      set
      {
        this["assemblyName"] = (object) value;
      }
    }

    [ConfigurationProperty("Parameters")]
    public ParameterElementCollection InputParameters
    {
      get
      {
        return this["Parameters"] as ParameterElementCollection;
      }
    }
  }
}
