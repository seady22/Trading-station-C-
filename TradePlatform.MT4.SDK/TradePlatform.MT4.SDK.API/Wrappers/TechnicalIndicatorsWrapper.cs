using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
   public  class TechnicalIndicatorsWrapper
    {
        public double iAC(MqlHandler handler, string symbol, TIME_FRAME timeframe, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iAC", symbol, ((int)timeframe), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iAD(MqlHandler handler, string symbol, TIME_FRAME timeframe, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iAD", symbol, ((int)timeframe), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iAlligator(MqlHandler handler, string symbol, TIME_FRAME timeframe, int jaw_period, int jaw_shift, int teeth_period, int teeth_shift, int lips_period, int lips_shift, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, GATOR_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iAlligator", symbol, ((int)timeframe), jaw_period, jaw_shift, teeth_period, teeth_shift, lips_period, lips_shift, ((int)ma_method), ((int)appliedApplyPrice), ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iADX(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, ADX_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iADX", symbol, ((int)timeframe), period, ((int)appliedApplyPrice), ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iATR(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iATR", symbol, ((int)timeframe), period, shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iAO(MqlHandler handler, string symbol, TIME_FRAME timeframe, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iAO", symbol, ((int)timeframe), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iBearsPower(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iBearsPower", symbol, ((int)timeframe), period, shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iBands(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int deviation, int bands_shift, APPLY_PRICE appliedApplyPrice, BAND_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iBands", symbol, ((int)timeframe), period, deviation, bands_shift, ((int)appliedApplyPrice), ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }
       
        public double iBullsPower(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iBullsPower", symbol, ((int)timeframe), period, ((int)appliedApplyPrice), shift);
            return Convertor.ToDouble(retrunValue);
        }
      
        public double iCCI(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iCCI", symbol, ((int)timeframe), period, ((int)appliedApplyPrice), shift);
            return Convertor.ToDouble(retrunValue);
        }
        
        public double iDeMarker(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iDeMarker", symbol, ((int)timeframe), period, shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iEnvelopes(MqlHandler handler, string symbol, TIME_FRAME timeframe, int ma_period, MA_METHOD ma_method, int ma_shift, APPLY_PRICE appliedApplyPrice, double deviation, BAND_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iEnvelopes", symbol, ((int)timeframe), ma_period, ((int)ma_method), ma_shift, ((int)appliedApplyPrice), deviation, ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iForce(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iForce", symbol, ((int)timeframe), period, ((int)ma_method), ((int)appliedApplyPrice), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iFractals(MqlHandler handler, string symbol, TIME_FRAME timeframe, BAND_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iFractals", symbol, ((int)timeframe), ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iGator(MqlHandler handler, string symbol, TIME_FRAME timeframe, int jaw_period, int jaw_shift, int teeth_period, int teeth_shift, int lips_period, int lips_shift, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, BAND_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iGator", symbol, ((int)timeframe), jaw_period, jaw_shift, teeth_period, teeth_shift, lips_period, lips_shift, ((int)ma_method), ((int)appliedApplyPrice), ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iIchimoku(MqlHandler handler, string symbol, TIME_FRAME timeframe, int tenkan_sen, int kijun_sen, int senkou_span_b, ICHIMOKU_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iIchimoku", symbol, ((int)timeframe), tenkan_sen, kijun_sen, senkou_span_b, ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iBWMFI(MqlHandler handler, string symbol, TIME_FRAME timeframe, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iBWMFI", symbol, ((int)timeframe), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iMomentum(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iMomentum", symbol, ((int)timeframe), period, ((int)appliedApplyPrice), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iMFI(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iMFI", symbol, ((int)timeframe), period, shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iMA(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int ma_shift, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iMA", symbol, ((int)timeframe), period, ma_shift, ((int)ma_method), ((int)appliedApplyPrice), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iOsMA(MqlHandler handler, string symbol, TIME_FRAME timeframe, int fast_ema_period, int slow_ema_period, int signal_period, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iOsMA", symbol, ((int)timeframe), fast_ema_period, slow_ema_period, signal_period, ((int)appliedApplyPrice), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iMACD(MqlHandler handler, string symbol, TIME_FRAME timeframe, int fast_ema_period, int slow_ema_period, int signal_period, APPLY_PRICE appliedApplyPrice, MACD_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iMACD", symbol, ((int)timeframe), fast_ema_period, slow_ema_period, signal_period, ((int)appliedApplyPrice), ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }

      
        public double iOBV(MqlHandler handler, string symbol, TIME_FRAME timeframe, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iOBV", symbol, ((int)timeframe), ((int)appliedApplyPrice), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iSAR(MqlHandler handler, string symbol, TIME_FRAME timeframe, double step, double maximum, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iSAR", symbol, ((int)timeframe), step, maximum, shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iRSI(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iRSI", symbol, ((int)timeframe), period, ((int)appliedApplyPrice), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iRVI(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, MACD_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iRVI", symbol, ((int)timeframe), period, ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }

        
        public double iStdDev(MqlHandler handler, string symbol, TIME_FRAME timeframe, int ma_period, int ma_shift, MA_METHOD ma_method, APPLY_PRICE appliedApplyPrice, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iStdDev", symbol, ((int)timeframe), ma_period, ma_shift, ((int)ma_method), ((int)appliedApplyPrice), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iStochastic(MqlHandler handler, string symbol, TIME_FRAME timeframe, int Kperiod, int Dperiod, int slowing, MA_METHOD method, APPLY_PRICE applyPriceField, MACD_MODE mode, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iStochastic", symbol, ((int)timeframe), Kperiod, Dperiod, slowing, ((int)method), applyPriceField, ((int)mode), shift);
            return Convertor.ToDouble(retrunValue);
        }

        public double iWPR(MqlHandler handler, string symbol, TIME_FRAME timeframe, int period, int shift)
        {
            string retrunValue = handler.CallMqlMethod("iWPR", symbol, ((int)timeframe), period, shift);
            return Convertor.ToDouble(retrunValue);
        }
    }
}
