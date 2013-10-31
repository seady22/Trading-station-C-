using System.Collections.Generic;

namespace TradePlatform.MT4.Db
{
    public interface IRepository<T>
    {
        T Get(object id);
        void Save(T value);
        void Update(T value);
        void Delete(T value);
        IList<T> GetAll();
    }
}
