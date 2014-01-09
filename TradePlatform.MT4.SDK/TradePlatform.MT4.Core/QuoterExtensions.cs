using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.Core
{
  internal static class QuoterExtensions
  {
    internal static int AccountNumber(this QuoteListener nandler)
    {
      return Convertor.ToInt(nandler.CallMqlMethod("AccountNumber", (object[]) null));
    }

    internal static string Symbol(this QuoteListener handler)
    {
      return handler.CallMqlMethod("Symbol", (object[]) null);
    }
  }
}
