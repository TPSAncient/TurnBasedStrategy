using System.Collections.Generic;

namespace Core.Data.World
{
    public class StaticCountryDictionary : IDataDictionary<StaticCountry>
    {
        public Dictionary<string, StaticCountry> Data { get; set; }
        public DataType DataType { get; set; }
    }
}