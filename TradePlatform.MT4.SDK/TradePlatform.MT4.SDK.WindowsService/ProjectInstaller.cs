using System.ComponentModel;

namespace TradePlatform.MT4.SDK.WindowsService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void TradePlatformExperts_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {

        }
    }
}
