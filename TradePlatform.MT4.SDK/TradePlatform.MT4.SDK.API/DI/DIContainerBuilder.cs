using Autofac;
using TradePlatform.MT4.SDK.API.Wrappers;

namespace TradePlatform.MT4.SDK.API.DI
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
