using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
    public class PredefinedVariablesWrapper
    {
        public  double Ask(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Ask", null);

            return Convertor.ToDouble(retrunValue);
        }

        public double  Bid(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Bid", null);

            return Convertor.ToDouble(retrunValue);
        }

        public double Close(MqlHandler handler, int i)
        {
            string retrunValue = handler.CallMqlMethod("Close", i);

            return Convertor.ToDouble(retrunValue);
        }

        public  double Open(MqlHandler handler, int i)
        {
            string retrunValue = handler.CallMqlMethod("Open", i);

            return Convertor.ToDouble(retrunValue);
        }

        public  double Point( MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("Point", null);

            return Convertor.ToDouble(retrunValue);
        }

    }
}
