using System.ServiceProcess;
using log4net;

namespace TradePlatform.MT4.SDK.WindowsService
{
    public partial class TradePlatformExperts : ServiceBase
    {
        private static readonly ILog _log = log4net.LogManager.GetLogger("GeneralLog");
        public TradePlatformExperts()
        {
            InitializeComponent();
            _log.DebugFormat("Log working");
        }

        protected override void OnStart(string[] args)
        {
            _log.DebugFormat("Service started");
        }

        protected override void OnStop()
        {
            _log.DebugFormat("Service stoped");
        }
    }
}
