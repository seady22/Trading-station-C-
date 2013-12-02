using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
    public class PredefinedVariabledWrapper
    {
        public double Ask(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Ask", null);
            return Convertor.ToDouble(retrunValue);
        }

       
        public int Bars(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Bars", null);
            return Convertor.ToInt(retrunValue);
        }

        public double Bid(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Bid", null);
            return Convertor.ToDouble(retrunValue);
        }

       
        public double Close(MqlHandler handler, int i)
        {
            string retrunValue = handler.CallMqlMethod("Close", i);
            return Convertor.ToDouble(retrunValue);
        }

       
        public double iClose(MqlHandler handler, string symbol, int i, TIME_FRAME timeFrame)
        {
            string retrunValue = handler.CallMqlMethod("iClose", symbol, i, (int)timeFrame);
            return Convertor.ToDouble(retrunValue);
        }

      
        public int Digits(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Digits", null);
            return Convertor.ToInt(retrunValue);
        }

        
        public double High(MqlHandler handler, int i)
        {
            string retrunValue = handler.CallMqlMethod("High", i);
            return Convertor.ToDouble(retrunValue);
        }


        public double Low(MqlHandler handler, int i)
        {
            string retrunValue = handler.CallMqlMethod("Low", i);
            return Convertor.ToDouble(retrunValue);
        }

        public double Open(MqlHandler handler, int i)
        {
            string retrunValue = handler.CallMqlMethod("Open", i);
            return Convertor.ToDouble(retrunValue);
        }

        public double Point(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Point", null);
            return Convertor.ToDouble(retrunValue);
        }

        public DateTime Time(MqlHandler handler, int i)
        {
            string retrunValue = handler.CallMqlMethod("Time", i);
            return Convertor.ToDateTime(retrunValue);
        }

      
        public double Volume(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Volume", null);
            return Convertor.ToDouble(retrunValue);
        }

        public int IndicatorCounted(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("IndicatorCounted", null);
            return Convertor.ToInt(retrunValue);
        }
    }
}
