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
        
        [SetUp]
        public void Init()
        {
            _sut = new LineBalanceAdvisor
                {
                    TradingFunctionWrapper = _tradingFunctionWrapper.Object,
                    LineBalanceAdvisorDetails = _lineBalanceAdvisorDetailsRepository.Object,
                    AccountInformationWrapper = _accountInformationWrapper.Object,
                    PredefinedVariablesWrapper = _predefinedVariablesWrapper.Object
                };
        }

        [Test]
        public void Start_ShouldUpdateEntityInDb_WhenOrderWasActive()
        {
            SetupOrdersTotal(1);
            SetupLineBalanceAdvisorDetails(State.Created);
            SetupAccountBalance(1.56);
            _sut.ResolveMethod("Start", new List<string>());

            _lineBalanceAdvisorDetailsRepository.Verify(m=>m.Update(It.Is<LineBalanceAdvisorDetails>(x=>x.State == State.Active && x.CurrentBalance ==1.56)));
        }

        private void SetupOrdersTotal(int value)
        {
            _tradingFunctionWrapper.Setup(m => m.OrdersTotal(It.IsAny<MqlHandler>())).Returns(value);
        }

        private void SetupLineBalanceAdvisorDetails(State state)
        {
            _lineBalanceAdvisorDetailsRepository.Object.Items.Add(new LineBalanceAdvisorDetails
                {
                    State = state
                });
        }

        [Test]
        public void Start_ShouldUpdateEntity_WhenOrderWasClosed()
        {
            SetupOrdersTotal(0);
            SetupLineBalanceAdvisorDetails(State.Active);
            SetupAccountBalance(1.56);

            _sut.ResolveMethod("Start", new List<string>());
            _lineBalanceAdvisorDetailsRepository.Verify(m => m.Update(It.Is<LineBalanceAdvisorDetails>(x => x.State == State.Closed &&
                                                                                                             x.UpdatedBalance == 1.56)));
        }

        private void SetupAccountBalance(double value)
        {
            _accountInformationWrapper.Setup(m => m.AccountBalance(It.IsAny<MqlHandler>())).Returns(value);
        }

        private void SetupAskPrice(double ask)
        {
            _predefinedVariablesWrapper.Setup(m => m.Ask(It.IsAny<MqlHandler>())).Returns(ask);
        }

        private void SetupBidPrice(double bid)
        {
            _predefinedVariablesWrapper.Setup(m => m.Bid(It.IsAny<MqlHandler>())).Returns(bid);
        }

        private void SetupIma(double imaPrice)
        {
            _technicalIndicatorsWrapper.Setup(
                m =>
                m.iMA(It.IsAny<MqlHandler>(), It.IsAny<string>(), It.IsAny<TIME_FRAME>(), It.IsAny<int>(),
                      It.IsAny<int>(), It.IsAny<MA_METHOD>(), It.IsAny<APPLY_PRICE>(), It.IsAny<int>()))
                                       .Returns(imaPrice);
        }

        [Test]
        public void Start_ShouldCreateBuyStopOrder()
        {
            SetupAskPrice(2);
            SetupBidPrice(2);
            SetupIma(1);

        }
    }
}
