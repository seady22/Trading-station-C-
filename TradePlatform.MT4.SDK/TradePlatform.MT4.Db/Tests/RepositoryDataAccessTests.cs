using System;
using System.Linq;
using MbUnit.Framework;
using TradePlatform.MT4.Db.Entities;
using TradePlatform.MT4.SDK.API;
using TradePlatform.MT4.SDK.API.Constants;

namespace TradePlatform.MT4.Db.Tests
{
    [TestFixture, Parallelizable(TestScope.All)]
    public class RepositoryDataAccessTests
    {
        [Test]
        public void Save_ShouldAddEntityCorrectly()
        {
            var repository = new Repository<ExpertDetails>();
            var countBeforeInsert = repository.GetAll().Count;

            repository.Save(new ExpertDetails
                {
                    Pair = SymbolsEnum.GBPUSD,
                    BalanceOnCreate = 1.156,
                    CreatedOn = DateTime.UtcNow,
                    TrendType = TREND_TYPE.ASC,
                    State = State.Created,
                    TimeFrame = TIME_FRAME.PERIOD_H1
                });

            var countAfterInsert = repository.GetAll().Count;
            Assert.AreEqual(countBeforeInsert + 1, countAfterInsert);
        }

        [Test]
        public void Update_ShouldUpdateDataCorrectly_WhenDealClosed()
        {
            var repository = new Repository<ExpertDetails>();
            repository.Save(new ExpertDetails
            {
                Pair = SymbolsEnum.EURUSD,
                BalanceOnCreate = 1.156,
                CreatedOn = DateTime.UtcNow,
                TrendType = TREND_TYPE.DESC,
                State = State.Active,
                TimeFrame = TIME_FRAME.PERIOD_H1,
            });

            var item = repository.GetAll().Where(x => x.State == State.Active && x.Pair == SymbolsEnum.EURUSD).Single();
            item.BalanceOnClose = 1.67;
            item.ClosedOn = DateTime.Now;
            item.State = State.Closed;
            repository.Update(item);
        }
    }
}
