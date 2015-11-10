using System.Collections.Generic;

namespace Core.Data.World
{
    public struct StaticPlayerDictionary : IDataDictionary<StaticPlayer>
    {
        public Dictionary<string, StaticPlayer> Data { get; set; }
        public DataType DataType { get; set; }
    }
}