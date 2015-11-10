using System.Collections.Generic;

namespace Core.Data.World.Region
{
    public class StaticInfrastructureDictionary : IDataDictionary<StaticInfrastructure>
    {
        public Dictionary<string, StaticInfrastructure> Data { get; set; }
        public void Add(string key, StaticInfrastructure value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; } = DataType.Infrastructure;
    }
}