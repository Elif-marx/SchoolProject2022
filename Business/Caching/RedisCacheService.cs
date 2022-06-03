using System.Text.Json;
using StackExchange.Redis;

namespace Business.Caching
{
    public class RedisCacheService : ICacheService
    {
        private readonly IConnectionMultiplexer connectionMultiplexer;
        private readonly IDatabase _redisCacheDatabase;

        public RedisCacheService()
        {
            connectionMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            _redisCacheDatabase = connectionMultiplexer.GetDatabase(0);
        }
        public bool Exists(string key)
        {
            return _redisCacheDatabase.KeyExists(key);
        }

        public T Get<T>(string key)
        {
            var jsonString = _redisCacheDatabase.StringGet(key);
            var data = JsonSerializer.Deserialize<T>(jsonString);
            return data;
        }

        public void Remove(string key)
        {
            _redisCacheDatabase.KeyDelete(key);
        }

        public void Set<T>(string key, T data)
        {
            var jsonString = JsonSerializer.Serialize(data);
            _redisCacheDatabase.StringSet(key, jsonString);
        }
    }
}
