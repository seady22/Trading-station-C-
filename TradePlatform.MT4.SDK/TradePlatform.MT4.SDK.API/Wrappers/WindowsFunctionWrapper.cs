using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
    public class WindowsFunctionWrapper
    {
        public void HideTestIndicators(MqlHandler handler, bool hide)
        {
            string retrunValue = handler.CallMqlMethod("HideTestIndicators", hide ? 1 : 0);
        }

        public int Period(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Period");
            return Convertor.ToInt(retrunValue);
        }

        public bool RefreshRates(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("RefreshRates");
            return Convertor.ToBoolean(retrunValue);
        }

        public string Symbol(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Symbol");
            return retrunValue;
        }

        public int WindowBarsPerChart(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowBarsPerChart");
            return Convertor.ToInt(retrunValue);
        }

        public string WindowExpertName(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowExpertName");
            return retrunValue;
        }

        public int WindowFind(MqlHandler handler, string name)
        {
            string retrunValue = handler.CallMqlMethod("WindowFind", name);
            return Convertor.ToInt(retrunValue);
        }

        public int WindowFirstVisibleBar(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowFirstVisibleBar");
            return Convertor.ToInt(retrunValue);
        }

        public int WindowHandle(MqlHandler handler, string symbol, TIME_FRAME timeframe)
        {
            string retrunValue = handler.CallMqlMethod("WindowHandle", symbol, ((int)timeframe));
            return Convertor.ToInt(retrunValue);
        }

        public bool WindowIsVisible(MqlHandler handler, int index)
        {
            string retrunValue = handler.CallMqlMethod("WindowIsVisible", index);
            return Convertor.ToBoolean(retrunValue);
        }

        public int WindowOnDropped(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowOnDropped");
            return Convertor.ToInt(retrunValue);
        }

        public double WindowPriceMax(MqlHandler handler, int index = 0)
        {
            string retrunValue = handler.CallMqlMethod("WindowPriceMax", index);
            return Convertor.ToDouble(retrunValue);
        }

        public double WindowPriceMin(MqlHandler handler, int index = 0)
        {
            string retrunValue = handler.CallMqlMethod("WindowPriceMin", index);
            return Convertor.ToDouble(retrunValue);
        }

        public double WindowPriceOnDropped(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowPriceOnDropped");
            return Convertor.ToDouble(retrunValue);
        }

        public void WindowRedraw(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowRedraw");
        }

        public bool WindowScreenShot(MqlHandler handler, string filename, int size_x, int size_y, int start_bar = -1, int chart_scale = -1, int chart_mode = -1)
        {
            string retrunValue = handler.CallMqlMethod("WindowScreenShot", filename, size_x, size_y, start_bar, chart_scale, chart_mode);
            return Convertor.ToBoolean(retrunValue);
        }

        public DateTime WindowTimeOnDropped(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowTimeOnDropped");
            return Convertor.ToDateTime(retrunValue);
        }

        public int WindowsTotal(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowsTotal");
            return Convertor.ToInt(retrunValue);
        }

        public int WindowXOnDropped(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowXOnDropped");
            return Convertor.ToInt(retrunValue);
        }

        public int WindowYOnDropped(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("WindowYOnDropped");
            return Convertor.ToInt(retrunValue);
        }
    }
}
