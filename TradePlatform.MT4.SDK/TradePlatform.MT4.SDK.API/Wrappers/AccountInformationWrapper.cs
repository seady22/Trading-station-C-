using TradePlatform.MT4.Core;
using TradePlatform.MT4.Core.Utils;

namespace TradePlatform.MT4.SDK.API.Wrappers
{
   public  class AccountInformationWrapper
    {
        public double AccountBalance(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountBalance", null);
            return Convertor.ToDouble(returnValue);
        }
      
        public  double AccountCredit(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountCredit", null);
            return Convertor.ToDouble(returnValue);
        }

        public string AccountCompany(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountCompany", null);
            return returnValue;
        }

        public  string AccountCurrency(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountCurrency", null);
            return returnValue;
        }

        public double AccountEquity(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountEquity", null);
            return Convertor.ToDouble(returnValue);
        }

        public  double AccountFreeMargin(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountFreeMargin", null);
            return Convertor.ToDouble(returnValue);
        }

        public  double AccountFreeMarginCheck(MqlHandler handler, string symbol, ORDER_TYPE cmd, double volume)
        {
            string returnValue = handler.CallMqlMethod("AccountFreeMarginCheck", symbol, (int)cmd, volume);
            return Convertor.ToDouble(returnValue);
        }

        public  double AccountFreeMarginMode(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountFreeMarginMode", null);
            return Convertor.ToDouble(returnValue);
        }

        public  int AccountLeverage(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountLeverage", null);
            return Convertor.ToInt(returnValue);
        }

        public double AccountMargin(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountMargin", null);
            return Convertor.ToDouble(returnValue);
        }

        public string AccountName(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountName", null);
            return returnValue;
        }

        public  int AccountNumber(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountNumber", null);
            return Convertor.ToInt(returnValue);
        }

        public  double AccountProfit(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountProfit", null);
            return Convertor.ToDouble(returnValue);
        }

        public  string AccountServer(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountServer", null);
            return returnValue;
        }

        public  int AccountStopoutLevel(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountStopoutLevel", null);
            return Convertor.ToInt(returnValue);
        }

        public  int AccountStopoutMode(MqlHandler handler)
        {
            string returnValue = handler.CallMqlMethod("AccountStopoutMode", null);
            return Convertor.ToInt(returnValue);
        }
    }
}
