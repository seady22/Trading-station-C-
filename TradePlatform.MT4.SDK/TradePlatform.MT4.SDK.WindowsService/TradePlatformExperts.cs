using System.ServiceProcess;

namespace TradePlatform.MT4.SDK.WindowsService
{
    public partial class TradePlatformExperts : ServiceBase
    {
        public TradePlatformExperts()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
