using System.Collections.Generic;

namespace ViewsAndSheetsSync
{
    public static class DictionaryExtensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue defaultValue = default(TValue))
        {
            return dict.TryGetValue(key, out TValue val) ? val : defaultValue;
        }
    }
}