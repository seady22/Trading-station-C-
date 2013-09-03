using NUnit.Framework;
using TradePlatform.MT4.Db.Entities;

namespace TradePlatform.MT4.Db
{
     [TestFixture]
    class DbConnectionTests
    {
         [Test]
         public void BuildSessionFactory_ShouldReturnSessionFactory()
         {
             var repository = new Repository<LineBalanceAdvisorDetails>();
             repository.Insert(new LineBalanceAdvisorDetails
                 {
                     Content = "test"
                 });
         }
    }
}
