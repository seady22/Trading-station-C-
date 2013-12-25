using System.ServiceProcess;
using TradePlatform.MT4.Core;
using log4net;

namespace TradePlatform.MT4.SDK.WindowsService
{
    public partial class TradePlatformExperts : ServiceBase
    {
        private readonly ILog _log = LogManager.GetLogger(typeof (TradePlatformExperts));
        public TradePlatformExperts()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            Bridge.InitializeHosts();
           _log.DebugFormat("Service started");
        }

        protected override void OnStop()
        {
            _log.DebugFormat("Service stoped");
        }
    }
}
