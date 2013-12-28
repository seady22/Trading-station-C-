using System.ServiceProcess;
using ServiceProcess.Helpers;

namespace TradePlatform.MT4.SDK.QuartzService
{
    static class Program
    {
        private static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
                {
                    new QuartzService()
                };
            //ServiceBase.Run(ServicesToRun);
            ServicesToRun.LoadServices();
        }
    }
}
