using System;
using System.ComponentModel.Composition;

namespace TradePlatform.MT4.Engine.Extension
{
  [MetadataAttribute]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class MinIntervalAttribute : Attribute
  {
    public int MinInterval { get; private set; }

    public MinIntervalAttribute(int milliseconds)
    {
      this.MinInterval = milliseconds;
    }
  }
}
