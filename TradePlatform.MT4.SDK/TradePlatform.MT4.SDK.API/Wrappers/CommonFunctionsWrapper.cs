using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
    public class CommonFunctionsWrapper
    {
        public  double MarketInfo(MqlHandler handler, string symbol, MARKER_INFO_MODE mode)
        {
            string retrunValue = handler.CallMqlMethod("MarketInfo", symbol, (int)mode);

            return Convertor.ToDouble(retrunValue);
        }
    }
}
