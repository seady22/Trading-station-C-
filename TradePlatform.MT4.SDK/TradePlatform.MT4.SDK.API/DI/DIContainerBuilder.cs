using Autofac;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API.Wrappers;

namespace TradePlatform.MT4.SDK.API.DI
{
    public class DIContainerBuilder
    {
        private readonly ContainerBuilder _containerBuilder = new ContainerBuilder();

        public DIContainerBuilder()
        {
            _containerBuilder.RegisterType<TradingFunctionWrapper>();
            _containerBuilder.RegisterType<Repository<LineBalanceAdvisorDetails>>();
            _containerBuilder.RegisterType<AccountInformationWrapper>();
            _containerBuilder.RegisterType<PredefinedVariablesWrapper>();
            _containerBuilder.RegisterType<TechnicalIndicatorsWrapper>();
            _containerBuilder.RegisterType<PredefinedVariablesWrapper>();
            _containerBuilder.RegisterType<CommonFunctionsWrapper>();
        }

        public IContainer Build()
        {
            return _containerBuilder.Build();
        }
    }
}
