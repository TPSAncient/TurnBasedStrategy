using System.Collections.Generic;

namespace Core.Data.World.Region
{
    public class StaticCityDictionary : IDataDictionary<StaticCity>
    {
        public Dictionary<string, StaticCity> Data { get; set; } = new Dictionary<string, StaticCity>();
        public void Add(string key, StaticCity value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; } = DataType.City;
    }
}