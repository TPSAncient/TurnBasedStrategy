using System.Collections.Generic;

namespace Core.Data.World.Region
{
    public class StaticPortDictionary : IDataDictionary<StaticPort>
    {
        public Dictionary<string, StaticPort> Data { get; set; } = new Dictionary<string, StaticPort>();
        public void Add(string key, StaticPort value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; } = DataType.Port;
    }
}