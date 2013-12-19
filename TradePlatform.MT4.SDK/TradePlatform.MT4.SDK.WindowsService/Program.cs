using System.ServiceProcess;

namespace TradePlatform.MT4.SDK.WindowsService
{
    static class Program
    {

        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new TradePlatformExperts() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
