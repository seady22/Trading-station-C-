using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
    public class AccountInformationWrapper
    {
        public virtual  double AccountBalance(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("AccountBalance", null);

            return Convertor.ToDouble(retrunValue);
        }
    }
}
