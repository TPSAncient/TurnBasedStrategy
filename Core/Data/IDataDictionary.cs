using System.Collections.Generic;

namespace Core.Data
{
    public interface IDataDictionary<T>
    {
         Dictionary<string,T> Data { get; set; }

        DataType DataType { get; set; }
    }
}