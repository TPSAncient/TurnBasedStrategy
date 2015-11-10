using System.Collections.Generic;

namespace Core.Data.World
{
    public class StaticProvinceDictionary : IDataDictionary<StaticProvince>
    {
        public Dictionary<string, StaticProvince> Data { get; set; }
        public DataType DataType { get; set; }
    }
}