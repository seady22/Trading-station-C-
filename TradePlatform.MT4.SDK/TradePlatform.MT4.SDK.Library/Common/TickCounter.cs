using System.Threading;

namespace TradePlatform.MT4.SDK.Library.Common
{
    using System;
    using TradePlatform.MT4.SDK.Library.Handlers;

    public class TickCounter : PerformanceCounterBase
    {
        private DateTime _beginTime;
        private DateTime _endTime;

        protected override void Begin()
        {
            this._beginTime = DateTime.Now;
            Thread.Sleep(30000);
        }

        protected override void End()
        {
            this._endTime = DateTime.Now;
            Thread.Sleep(30000);
            //Trace.Write(new TraceInfo(BridgeTraceErrorType.Service, message: "Last tick time: " + (this._endTime - this._beginTime).TotalMilliseconds + " ms."));
        }
    }
}
