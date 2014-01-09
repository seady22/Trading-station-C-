using System;

namespace TradePlatform.MT4.Engine.Exceptions
{
  public class TraceListenerException : Exception
  {
    public TraceListenerException(object value, string message)
      : base(string.Format("{0} [Passed Value={1}]", (object) message, value))
    {
    }
  }
}
