using System.Collections.Generic;

namespace Core.Data.World
{
    public class StaticRegionDictionary : IDataDictionary<StaticRegion>
    {
        public Dictionary<string, StaticRegion> Data { get; set; }
        public DataType DataType { get; set; }
    }
}