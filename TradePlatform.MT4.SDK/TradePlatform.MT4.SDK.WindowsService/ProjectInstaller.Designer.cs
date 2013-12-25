namespace TradePlatform.MT4.SDK.WindowsService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TradePlatformExperts = new System.ServiceProcess.ServiceProcessInstaller();
            this.TradePlatformExpertsInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // TradePlatformExperts
            // 
            this.TradePlatformExperts.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.TradePlatformExperts.Password = null;
            this.TradePlatformExperts.Username = null;
            this.TradePlatformExperts.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.TradePlatformExperts_AfterInstall);
            // 
            // TradePlatformExpertsInstaller
            // 
            this.TradePlatformExpertsInstaller.DelayedAutoStart = true;
            this.TradePlatformExpertsInstaller.DisplayName = "TradePlatformExperts";
            this.TradePlatformExpertsInstaller.ServiceName = "TradePlatformExperts";
            this.TradePlatformExpertsInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.TradePlatformExperts,
            this.TradePlatformExpertsInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceInstaller TradePlatformExpertsInstaller;
        private System.ServiceProcess.ServiceProcessInstaller TradePlatformExperts;

    }
}