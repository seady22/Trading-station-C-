using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
    public class TradingFunctionWrapper
    {
        public virtual int OrdersTotal(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("OrdersTotal", null);
            return Convertor.ToInt(returnValue);
        }
    }
}
