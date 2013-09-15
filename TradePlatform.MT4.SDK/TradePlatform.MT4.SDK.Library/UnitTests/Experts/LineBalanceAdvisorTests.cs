using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TradePlatform.MT4.Core;
using TradePlatform.MT4.SDK.API.Wrappers;
using TradePlatform.MT4.SDK.Library.Experts;

namespace TradePlatform.MT4.SDK.Library.UnitTests.Experts
{
    [TestFixture]
    public class LineBalanceAdvisorTests
    {
        private LineBalanceAdvisor _sut;
        private Mock<TradingFunctionWrapper> _tradingFunctionWrapper = new Mock<TradingFunctionWrapper>();
        
        [SetUp]
        public void Init()
        {
            _sut = new LineBalanceAdvisor
                {
                    TradingFunctionWrapper = _tradingFunctionWrapper.Object
                };
        }

        [Test]
        public void Start_ShouldUpdateEntityInDb_WhenOrderWasOpen()
        {
            _tradingFunctionWrapper.Setup(m => m.OrdersTotal(It.IsAny<MqlHandler>())).Returns(10);
            _sut.ResolveMethod("Start", new List<string>());
        }
    }
}
