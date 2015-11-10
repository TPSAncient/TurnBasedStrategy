using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Core.Data.World.Location
{
    public class StaticCityDictionary : IDataDictionary<StaticCity>
    {
        public Dictionary<string, StaticCity> Data { get; set; } = new Dictionary<string, StaticCity>();
        public void Add(string key, StaticCity value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; }
    }
}