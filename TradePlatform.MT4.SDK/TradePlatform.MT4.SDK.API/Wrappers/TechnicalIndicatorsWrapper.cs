using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
    public class TechnicalIndicatorsWrapper
    {
        public  double iMA(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int ma_shift, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iMA", symbol, ((int)timeframe), period, ma_shift, ((int)ma_method), ((int)appliedApplyPrice), shift);

            return Convertor.ToDouble(retrunValue);
        }
    }
}
