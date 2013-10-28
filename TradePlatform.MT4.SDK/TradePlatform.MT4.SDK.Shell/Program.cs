
using Autofac.Util;
using log4net;

namespace TradePlatform.MT4.SDK.Shell
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using Core;

    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(Assembly.GetAssembly(typeof(Program)), typeof(Program));
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            SetupConsole();

            InitializeHosts();
        }

        private static void SetupConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = string.Format(".NET Bridge Shell {0}", Assembly.GetExecutingAssembly().GetName().Version);

            Console.SetWindowPosition(0, 0);
            Console.WindowTop = 0;
            Console.WindowLeft = 0;

            Console.WindowWidth = 130;
            Console.SetWindowSize(130, 15);
            Console.WindowHeight = 15;

            Console.BufferHeight = Int16.MaxValue - 1;
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (!Debugger.IsAttached)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(((Exception)e.ExceptionObject).Message);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();

                Environment.Exit(1);
            }
        }

         static void InitializeHosts()
        {
            bool isMockEnabled = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["IsMockEnabled"]);
             if (isMockEnabled)
             {
                 _log.Debug("Mock was enabled");
             }
             else
             {
               _log.Debug("Mock was disabled");
                Bridge.InitializeHosts();
             }
        }
    }
}
