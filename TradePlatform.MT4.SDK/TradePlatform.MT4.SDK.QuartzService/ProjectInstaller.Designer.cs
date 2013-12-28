namespace TradePlatform.MT4.SDK.QuartzService
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
            this.QuartzProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.QuartzServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // QuartzProcessInstaller1
            // 
            this.QuartzProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.QuartzProcessInstaller1.Password = null;
            this.QuartzProcessInstaller1.Username = null;
            // 
            // QuartzServiceInstaller
            // 
            this.QuartzServiceInstaller.ServiceName = "TradePlatform.QuartzService";
            this.QuartzServiceInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceInstaller1_AfterInstall);
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.QuartzProcessInstaller1,
            this.QuartzServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller QuartzProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller QuartzServiceInstaller;
    }
}