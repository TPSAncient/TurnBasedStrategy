using System.Collections.Generic;

namespace Core.Data.World.Location
{
    public class StaticFarmDictionary : IDataDictionary<StaticFarm>
    {
        public Dictionary<string, StaticFarm> Data { get; set; }
        public DataType DataType { get; set; }
    }
}