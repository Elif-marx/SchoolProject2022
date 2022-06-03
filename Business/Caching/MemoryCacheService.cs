using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace Business.Caching
{
    public class MemoryCacheService : ICacheService
    {
        readonly IMemoryCache _memoryCache;
        public MemoryCacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public bool Exists(string key)
        {
            return _memoryCache.Get(key) != null ? true : false;
        }

        public T Get<T>(string key)
        {
            var data = _memoryCache.Get<T>(key);
            //var jsonString = JsonConvert.SerializeObject(data);
            return data;
        }

        public void Remove(string key)
        {
            _memoryCache.Remove(key);
        }

        public void Set<T>(string key, T data)
        {
            //var jsonString = JsonConvert.SerializeObject(data);
            _memoryCache.Set<T>(key, data);
        }
    }
}
