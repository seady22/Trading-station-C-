using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace TradePlatform.MT4.Db
{
    public class Repository<T> : IRepository<T>
    {
        protected ISessionFactory _sessionFactory;

        public Repository()
        {
            _sessionFactory = Fluently.Configure().Database(MySQLConfiguration.Standard
                                       .ConnectionString(c => c
                                       .Server("localhost")
                                       .Database("ExpertAdvisors")
                                       .Username("root")
                                       .Password("")))
                                       .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                                       .BuildSessionFactory();
        } 

        public void Insert(T entity)
        {
            using (var session = _sessionFactory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(entity);
                transaction.Commit();
            }
        }
    }
}
