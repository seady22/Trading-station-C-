using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.Db;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Wrappers;
using TradePlatform.MT4.SDK.Library.Experts;

namespace TradePlatform.MT4.SDK.Library.UnitTests.Experts
{
    [TestFixture]
    public class LineBalanceAdvisorTests
    {
        private LineBalanceAdvisor _sut;
        private Mock<TradingFunctionWrapper> _tradingFunctionWrapper = new Mock<TradingFunctionWrapper>();
        private Mock<Repository<LineBalanceAdvisorDetails>> _lineBalanceAdvisorDetailsRepository = new Mock<Repository<LineBalanceAdvisorDetails>>();
        private Mock<AccountInformationWrapper> _accountInformationWrapper = new Mock<AccountInformationWrapper>();
        private Mock<PredefinedVariablesWrapper> _predefinedVariablesWrapper = new Mock<PredefinedVariablesWrapper>();
        private Mock<TechnicalIndicatorsWrapper> _technicalIndicatorsWrapper = new Mock<TechnicalIndicatorsWrapper>();
        private Mock<CommonFunctionsWrapper> _commonFucntionsWrapper = new Mock<CommonFunctionsWrapper>();
        private Mock<TechnicalIndicatorsWrapper> _technicalIndicatiorsWrapper = new Mock<TechnicalIndicatorsWrapper>();
        
        [SetUp]
        public void Init()
        {
            _sut = new LineBalanceAdvisor
                {
                    TradingFunctionWrapper = _tradingFunctionWrapper.Object,
                    LineBalanceAdvisorDetailsRepository = _lineBalanceAdvisorDetailsRepository.Object,
                    AccountInformationWrapper = _accountInformationWrapper.Object,
                    PredefinedVariablesWrapper = _predefinedVariablesWrapper.Object,
                    CommonFunctionsWrapper = _commonFucntionsWrapper.Object,
                    TechnicalIndicatorsWrapper = _technicalIndicatiorsWrapper.Object
                };
        }
    }
}
