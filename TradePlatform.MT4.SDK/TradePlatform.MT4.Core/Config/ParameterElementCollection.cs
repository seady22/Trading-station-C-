using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace TradePlatform.MT4.Core.Config
{
  public class ParameterElementCollection : ConfigurationElementCollection
  {
    public override ConfigurationElementCollectionType CollectionType
    {
      get
      {
        return ConfigurationElementCollectionType.BasicMap;
      }
    }

    protected override string ElementName
    {
      get
      {
        return "Parameter";
      }
    }

    public ParameterElement this[int index]
    {
      get
      {
        return (ParameterElement) this.BaseGet(index);
      }
      set
      {
        if (this.BaseGet(index) != null)
          this.BaseRemoveAt(index);
        this.BaseAdd(index, (ConfigurationElement) value);
      }
    }

    new public ParameterElement this[string propertyName]
    {
      get
      {
        return (ParameterElement) this.BaseGet((object) propertyName);
      }
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return (ConfigurationElement) new ParameterElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return (object) ((ParameterElement) element).PropertyName;
    }

    public bool ContainsKey(string propertyName)
    {
      return Enumerable.Any<object>((IEnumerable<object>) this.BaseGetAllKeys(), (Func<object, bool>) (obj => (string) obj == propertyName));
    }
  }
}
