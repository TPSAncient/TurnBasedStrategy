using System.Collections.Generic;

namespace Core.Data.World.Region
{
    public class StaticIndustryDictionary : IDataDictionary<StaticIndustry>
    {
        public Dictionary<string, StaticIndustry> Data { get; set; }
        public void Add(string key, StaticIndustry value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; }
    }
}