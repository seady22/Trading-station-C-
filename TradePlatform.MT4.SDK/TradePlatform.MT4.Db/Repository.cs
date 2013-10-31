using System.Collections.Generic;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace TradePlatform.MT4.Db
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected Configuration config;
        protected ISessionFactory sessionFactory;

        public Repository()
        {
            var serverName = System.Configuration.ConfigurationManager.AppSettings["Server"];
            var dbName = System.Configuration.ConfigurationManager.AppSettings["DataBase"];
            var userName = System.Configuration.ConfigurationManager.AppSettings["UserName"];
            var pwd = System.Configuration.ConfigurationManager.AppSettings["Password"];

            config = Fluently.Configure().Database(MySQLConfiguration.Standard
                .ConnectionString(c => c
                    .Server(serverName)
                    .Database(dbName)
                    .Username(userName)
                    .Password(pwd)))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Repository<T>>()).BuildConfiguration();
        

            sessionFactory = config.BuildSessionFactory();
        }

        public T Get(object id)
        {
            using (var session = sessionFactory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                T returnVal = session.Get<T>(id);
                transaction.Commit();
                return returnVal;
            }
        }

        public void Save(T value)
        {
            using (var session = sessionFactory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(value);
                transaction.Commit();
            }
        }

        public void Update(T value)
        {
            using (var session = sessionFactory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Update(value);
                transaction.Commit();
            }
        }

        public void Delete(T value)
        {
            using (var session = sessionFactory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(value);
                transaction.Commit();
            }
        }

        public IList<T> GetAll()
        {
            using (var session = sessionFactory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                IList<T> returnVal = session.CreateCriteria<T>().List<T>();
                transaction.Commit();
                return returnVal;
            }
        }

        public void GenerateSchema()
        {
            new SchemaExport(config).Execute(true, true, false);
        }
    }
}
