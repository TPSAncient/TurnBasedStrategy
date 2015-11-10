using System.Collections.Generic;

namespace Core.Data.World.Province
{
    public class StaticProvinceDictionary : IDataDictionary<StaticProvince>
    {
        public Dictionary<string, StaticProvince> Data { get; set; } = new Dictionary<string, StaticProvince>();
        public void Add(string key, StaticProvince value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; }
    }
}