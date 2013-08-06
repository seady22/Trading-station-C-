namespace TradePlatform.MT4.SDK.Library.Experts
{
    using System;
    using System.Diagnostics;
    using TradePlatform.MT4.Core.Utils;
    using TradePlatform.MT4.SDK.API;
    using TradePlatform.MT4.SDK.Library.Handlers;

    public class MACrossExpert : ExtendedExpertAdvisor
    {
        bool fastUnderSlow = false;

        protected override int Init()
        {
            return 1;
        }

        protected override int Start()
        {
            Trace.Write(new TraceInfo(BridgeTraceErrorType.Service, message: "Expert was started"));
            
            var askPrice = PredefinedVariables.Bid(this);
            Trace.Write(new TraceInfo(BridgeTraceErrorType.Service, message: askPrice.ToString()));
            return 1;
        }

        protected override int DeInit()
        {
            return 1;
        }
    }
}

