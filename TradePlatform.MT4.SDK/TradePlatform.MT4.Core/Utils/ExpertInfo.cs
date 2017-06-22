

namespace TradePlatform.MT4.Core.Utils
{
  public sealed class ExpertInfo
  {
    public readonly string HandlerName;
    public readonly string Discriminator;
    public readonly MethodCallInfo MethodCallInfo;

    public ExpertInfo(string discriminator, string handlerName, MethodCallInfo methodCallInfo)
    {
      this.Discriminator = discriminator;
      this.HandlerName = handlerName;
      this.MethodCallInfo = methodCallInfo;
    }

    public override string ToString()
    {
      return "[HandlerName=" + this.HandlerName + ", Discriminator=" + this.Discriminator + "]." + this.MethodCallInfo;
    }
  }
}
