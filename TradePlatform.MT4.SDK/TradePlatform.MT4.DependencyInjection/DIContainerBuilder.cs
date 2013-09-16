using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TradePlatform.MT4.SDK.API.Wrappers;

namespace TradePlatform.MT4.DependencyInjection
{
    public class DIContainerBuilder
    {
        private readonly ContainerBuilder _containerBuilder = new ContainerBuilder();

        public DIContainerBuilder()
        {
            _containerBuilder.RegisterType<TradingFunctionWrapper>();
        }

        public IContainer Build()
        {
            return _containerBuilder.Build();
        }
    }
}
