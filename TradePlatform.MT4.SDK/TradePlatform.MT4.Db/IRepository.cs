using FluentNHibernate.Data;

namespace TradePlatform.MT4.Db
{
    public interface IRepository<T>
    {
        void Insert(T entity);
    }
}
