using System.Collections.Generic;

namespace Core.Data.Common
{
    public class StaticDictionary<T> : IDataDictionary<T>
    {
        public Dictionary<string, T> Data { get; set; } = new Dictionary<string,T>();
        public void Add(string key, T value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; }
    }
}