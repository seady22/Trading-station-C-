using System.Collections.Generic;

namespace TradePlatform.MT4.Core
{
  public abstract class Container<T> where T : new()
  {
    private static Dictionary<string, T> _storage = new Dictionary<string, T>();

    static Container()
    {
    }

    public static T GetOrCreate(string key)
    {
      if (Container<T>._storage.ContainsKey(key))
        return Container<T>._storage[key];
      T obj = new T();
      Container<T>._storage.Add(key, obj);
      return obj;
    }
  }
}
