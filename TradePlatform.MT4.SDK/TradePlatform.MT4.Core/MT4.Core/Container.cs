using System;
using System.Diagnostics;
using System.Reflection;
using Autofac;

namespace TradePlatform.MT4.Core
{
    public static class Container
    {
        private static IContainer _instance;

        public static IContainer GetInstance()
        {
            if (_instance == null)
                BootStrap();

            return _instance;
        }

        internal static void BootStrap()
        {
            try
            {
                var assembly = Assembly.Load("TradePlatform.MT4.DI");
                var type = assembly.GetType("TradePlatform.MT4.DI.DIContainerBuilder");
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Build");
                Instance = (IContainer)methodInfo.Invoke(instance, null);
                Trace.WriteLine("Container initialized");
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                Trace.WriteLine(ex.StackTrace);
                throw;
            }
        }


        public static T Resolve<T>()
        {
            return _instance.Resolve<T>();
        }

        public static IContainer Instance
        {
            get
            {
                if (_instance == null)
                {
                    BootStrap();
                }

                return _instance;
            }

            internal set
            {
                _instance = value;
            }
        }
    }
}
