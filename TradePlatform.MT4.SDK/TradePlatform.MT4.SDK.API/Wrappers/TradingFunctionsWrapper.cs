using System;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
    public class TradingFunctionsWrapper
    {
        public bool OrderClose(MqlHandler handler, int ticket, double lots, double price, int slippage, int color = 0)
        {
            string retrunValue = handler.CallMqlMethod("OrderClose", ticket, lots, price, slippage, color);
            return Convertor.ToBoolean(retrunValue);
        }

        public bool OrderCloseBy(MqlHandler handler, int ticket, int opposite, int color = 0)
        {
            string retrunValue = handler.CallMqlMethod("OrderCloseBy", ticket, opposite, color);
            return Convertor.ToBoolean(retrunValue);
        }

        public double OrderClosePrice(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderClosePrice", null);
            return Convertor.ToDouble(retrunValue);
        }

        public DateTime OrderCloseTime(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderCloseTime", null);
            return Convertor.ToDateTime(retrunValue);
        }

        public string OrderComment(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderComment", null);
            return retrunValue;
        }

        public double OrderCommission(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderCommission", null);
            return Convertor.ToDouble(retrunValue);
        }

        public bool OrderDelete(MqlHandler handler, int ticket, int color = 0)
        {
            string retrunValue = handler.CallMqlMethod("OrderDelete", ticket, color);
            return Convertor.ToBoolean(retrunValue);
        }

        public DateTime OrderExpiration(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderExpiration", null);
            return Convertor.ToDateTime(retrunValue);
        }

        public double OrderLots(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderLots", null);
            return Convertor.ToDouble(retrunValue);
        }

        public int OrderMagicNumber(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderMagicNumber", null);
            return Convertor.ToInt(retrunValue);
        }

        public bool OrderModify(MqlHandler handler, int ticket, double price, double stoploss, double takeprofit, DateTime expiration = default(DateTime), int arrow_color = 0)
        {
            string retrunValue = handler.CallMqlMethod("OrderModify", ticket, price, stoploss, takeprofit, expiration, arrow_color);
            return Convertor.ToBoolean(retrunValue);
        }

        public double OrderOpenPrice(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderOpenPrice", null);
            return Convertor.ToDouble(retrunValue);
        }

        public DateTime OrderOpenTime(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderOpenTime", null);
            return Convertor.ToDateTime(retrunValue);
        }

        public void OrderPrint(MqlHandler handler)
        {
            handler.CallMqlMethod("OrderPrint", null);
        }

        public double OrderProfit(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderProfit", null);
            return Convertor.ToDouble(retrunValue);
        }

        public bool OrderSelect(MqlHandler handler, int index, SELECT_BY select, POOL_MODES pool = POOL_MODES.MODE_TRADES)
        {
            string retrunValue = handler.CallMqlMethod("OrderSelect", index, (int)select, (int)pool);
            return Convertor.ToBoolean(retrunValue);
        }

        public int OrderSend(MqlHandler handler, string symbol, ORDER_TYPE cmd, double volume, double price, int slippage, double stoploss, double takeprofit, string comment = "", int magic = 0, DateTime expiration = default(DateTime), int arrow_color = 0)
        {
            string retrunValue = handler.CallMqlMethod("OrderSend", symbol, (int)cmd, volume, price, slippage, stoploss, takeprofit, comment, magic, expiration, arrow_color);
            return Convertor.ToInt(retrunValue);
        }

        public int HistoryTotal(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("HistoryTotal", null);
            return Convertor.ToInt(retrunValue);
        }

        public double OrderStopLoss(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderStopLoss", null);
            return Convertor.ToDouble(retrunValue);
        }

        public int OrdersTotal(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrdersTotal", null);
            return Convertor.ToInt(retrunValue);
        }

        public double OrderSwap(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderSwap", null);
            return Convertor.ToDouble(retrunValue);
        }

        public string OrderSymbol(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderSymbol", null);
            return retrunValue;
        }

        public double OrderTakeProfit(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderTakeProfit", null);
            return Convertor.ToDouble(retrunValue);
        }

        public int OrderTicket(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderTicket", null);
            return Convertor.ToInt(retrunValue);
        }

        public ORDER_TYPE OrderType(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("OrderType", null);
            return (ORDER_TYPE)Enum.Parse(typeof(ORDER_TYPE), retrunValue);
        }
    }
}
