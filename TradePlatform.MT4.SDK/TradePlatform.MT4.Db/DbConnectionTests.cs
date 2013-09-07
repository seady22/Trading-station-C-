using System;
using NUnit.Framework;
using TradePlatform.MT4.Db.Entities;

namespace TradePlatform.MT4.Db
{
     [TestFixture]
    class DbConnectionTests
    {
         [Test]
         public void Insert_ShouldAddRecordCorrectly()
         {
             var repository = new Repository<LineBalanceAdvisorDetails>();
             repository.Insert(new LineBalanceAdvisorDetails
                 {
                     CreatedOn = DateTime.UtcNow,
                     Pair = Pair.EURUSD,
                     State = 1,
                     TimeFrame = TimeFrame.H1
                 });
         }
    }
}
