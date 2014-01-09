using System;
using System.ComponentModel.Composition;

namespace TradePlatform.MT4.Engine.Extension
{
  [MetadataAttribute]
  public class NameAttribute : Attribute
  {
    public string Name { get; private set; }

    public NameAttribute(string name)
    {
      this.Name = name;
    }
  }
}
