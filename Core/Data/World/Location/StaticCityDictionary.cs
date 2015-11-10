using System.Collections.Generic;

namespace Core.Data.World.Location
{
    public class StaticCityDictionary : IDataDictionary<StaticCity>
    {
        public Dictionary<string, StaticCity> Data { get; set; }
        public DataType DataType { get; set; }
    }
}