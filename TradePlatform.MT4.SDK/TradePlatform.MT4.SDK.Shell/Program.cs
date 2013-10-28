﻿using Autofac;
using TradePlatform.MT4.Core.Utils;
using TradePlatform.MT4.SDK.API.Wrappers;

namespace TradePlatform.MT4.SDK.Shell
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using Core;

    class Program
    {
        static void Main(string[] args)
        {
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
                 Console.WriteLine("Mock was disabled");
             }
             else
             {
                Console.WriteLine("Mock was disabled");
                Bridge.InitializeHosts();
             }
        }
    }
}
