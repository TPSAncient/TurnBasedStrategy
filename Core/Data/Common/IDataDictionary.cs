using System.Collections.Generic;

namespace Core.Data.Common
{
    public interface IDataDictionary<T>
    {
        Dictionary<string,T> Data { get; set; }
        void Add(string key, T value);
        DataType DataType { get; set; }
    }
}