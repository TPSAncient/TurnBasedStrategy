using System.Collections.Generic;

namespace Core.Data.World
{
    public class StaticPlayerDictionary : IDataDictionary<StaticPlayer>
    {
        public Dictionary<string, StaticPlayer> Data { get; set; } = new Dictionary<string, StaticPlayer>();
        public void Add(string key, StaticPlayer value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; }
    }
}