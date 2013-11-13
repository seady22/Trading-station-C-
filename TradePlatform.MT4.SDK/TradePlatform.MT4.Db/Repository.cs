using System.Collections.Generic;
using System.Configuration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using TradePlatform.MT4.Db.Config;
using Configuration = NHibernate.Cfg.Configuration;

namespace TradePlatform.MT4.Db
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected Configuration config;
        protected ISessionFactory sessionFactory;

        public Repository()
        {
            var section = (DbConfiguration)ConfigurationManager.GetSection("DbConfiguration");
            var serverName = section.ConnectionStringElement.Server;
            var dbName = section.ConnectionStringElement.DataBase;
            var userName = section.ConnectionStringElement.Username;
            var pwd = section.ConnectionStringElement.Pwd;

            config = Fluently.Configure().Database(MySQLConfiguration.Standard
                .ConnectionString(c => c
                    .Server(serverName)
                    .Database(dbName)
                    .Username(userName)
                    .Password(pwd)))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Repository<T>>())
                .ExposeConfiguration(DropCreateSchema)
                .BuildConfiguration();

            sessionFactory = config.BuildSessionFactory();
        }

        private static void DropCreateSchema(Configuration cfg)
        {
            new SchemaUpdate(cfg).Execute(false, true);
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
    }
}
