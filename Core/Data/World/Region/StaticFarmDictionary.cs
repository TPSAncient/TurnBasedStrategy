using System.Collections.Generic;

namespace Core.Data.World.Region
{
    public class StaticFarmDictionary : IDataDictionary<StaticFarm>
    {
        public Dictionary<string, StaticFarm> Data { get; set; } = new Dictionary<string, StaticFarm>();
        public void Add(string key, StaticFarm value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; }
    }
}