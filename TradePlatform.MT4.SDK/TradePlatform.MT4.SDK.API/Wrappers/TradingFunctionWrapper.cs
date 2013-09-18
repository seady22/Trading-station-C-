using System;
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

        public virtual int OrderSend(MqlHandler handler, string symbol, ORDER_TYPE cmd, double volume, double price, int slippage, double stoploss, double takeprofit, string comment = "", int magic = 0, DateTime expiration = default(DateTime), int arrow_color = 0)
        {
            string retrunValue = handler.CallMqlMethod("OrderSend", symbol, (int)cmd, volume, price, slippage, stoploss, takeprofit, comment, magic, expiration, arrow_color);

            return Convertor.ToInt(retrunValue);
        } 
    }
}
