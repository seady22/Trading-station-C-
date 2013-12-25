using log4net;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.SDK.API.Wrappers;

namespace TradePlatform.MT4.SDK.API.Operations
{
    public class OrderOperations
    {
        private readonly TradingFunctionsWrapper _tradingFunctionsWrapper = new TradingFunctionsWrapper();
        protected ILog _log = LogManager.GetLogger(typeof(OrderOperations));

        public int OpenOffer(MqlHandler handler, string symbol, ORDER_TYPE orderType, double orderAmount, double price, int slippage, double stopLoss, double takeProfit)
        {
            var result = _tradingFunctionsWrapper.OrderSend(handler, symbol, orderType, orderAmount, price, slippage, stopLoss, takeProfit);

            _log.DebugFormat("Send offer. Symbol={0}, OrderType={1}, OrderAmount={2}, Price={3}, Slippage={4}, StopLoss={5}, TakeProfit={6}", symbol, orderType, orderAmount, price, slippage, stopLoss, takeProfit);
            _log.DebugFormat("Send offer. Result={0}", result);
            return result;
        }
    }
}
