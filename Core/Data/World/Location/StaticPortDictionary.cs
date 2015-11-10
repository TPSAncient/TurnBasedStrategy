using System.Collections.Generic;

namespace Core.Data.World.Location
{
    public class StaticPortDictionary : IDataDictionary<StaticPort>
    {
        public Dictionary<string, StaticPort> Data { get; set; }
        public DataType DataType { get; set; }
    }
}