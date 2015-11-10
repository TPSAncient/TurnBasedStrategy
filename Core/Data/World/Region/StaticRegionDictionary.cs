using System.Collections.Generic;

namespace Core.Data.World.Region
{
    public class StaticRegionDictionary : IDataDictionary<StaticRegion>
    {
        public Dictionary<string, StaticRegion> Data { get; set; } = new Dictionary<string, StaticRegion>();
        public void Add(string key, StaticRegion value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; } = DataType.Region;
    }
}