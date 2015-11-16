using System.Collections.Generic;
using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region
{
    public class StaticFarm : IData, IBuilding
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }

        public List<string> BuildingTag { get; set; } = new List<string>();
        
        [JsonIgnore]
        public StaticDictionary<StaticBuilding> Buildings { get; set; } = new StaticDictionary<StaticBuilding>();  
    }
}
