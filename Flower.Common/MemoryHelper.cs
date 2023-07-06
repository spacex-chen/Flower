using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xFlower.Common
{
    public class MemoryHelper
    {
        private static IMemoryCache _memoryCache;
        static MemoryHelper()
        {
            if (_memoryCache == null)
            {
                _memoryCache = new MemoryCache(new MemoryCacheOptions());
            }
        }
        public static void SetMemory(string key, object value, int expireMins)
        {
            _ = _memoryCache.Set(key, value, TimeSpan.FromMinutes(expireMins));
        }
        public static object GetMemory(string key)
        {
            if (_memoryCache != null)
            {
#pragma warning disable CS8603 // 可能返回 null 引用。
                return _memoryCache.Get(key);
#pragma warning restore CS8603 // 可能返回 null 引用。
            }
            else
            {
                return new MemoryCache(new MemoryCacheOptions());
            }
        }
    }
}
