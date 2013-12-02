using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
   public  class CommonFunctionsWrapper
    {
       
        public void Alert(MqlHandler handler, string message)
        {
            string retrunValue = handler.CallMqlMethod("Alert", message);
        }

        public void Comment(MqlHandler handler, string message)
        {
            string retrunValue = handler.CallMqlMethod("Comment", message);
        }
  
        public int GetTickCount(MqlHandler handler)
        {
            string retrunValue = handler.CallMqlMethod("GetTickCount", null);
            return Convertor.ToInt(retrunValue);
        }

        public double MarketInfo(MqlHandler handler, string symbol, MARKER_INFO_MODE mode)
        {
            string retrunValue = handler.CallMqlMethod("MarketInfo", symbol, (int)mode);
            return Convertor.ToDouble(retrunValue);
        }
 
        public void PlaySound(MqlHandler handler, string filename)
        {
            string retrunValue = handler.CallMqlMethod("PlaySound", filename);
        }

        public void Print(MqlHandler handler, string message)
        {
            string retrunValue = handler.CallMqlMethod("Print", message);
        }
   
        public bool SendNotification(MqlHandler handler, string notification)
        {
            string retrunValue = handler.CallMqlMethod("SendNotification", notification);
            return Convertor.ToBoolean(retrunValue);
        }
    }
}
