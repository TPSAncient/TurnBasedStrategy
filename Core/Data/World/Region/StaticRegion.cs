using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region
{
    public class StaticRegion : IData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DataType DataType { get; set; }

        public string TagName { get; set; }

        public int Player { get; set; }

        public string ProvinceTag { get; set; }
        public string CityTag { get; set; }
        public string FarmTag { get; set; }
        public string PortTag { get; set; }
        public string InfrastructureTag { get; set; }
        public string IndustryTag { get; set; }
        
        public bool CanBuildPort { get; set; }

        [JsonIgnore]
        public StaticCity City { get; set; }
        [JsonIgnore]
        public StaticFarm Farm { get; set; }
        [JsonIgnore]
        public StaticPort Port { get; set; }
        [JsonIgnore]
        public StaticInfrastructure Infrastructure { get; set; }
        [JsonIgnore]
        public StaticIndustry Industry { get; set; }

        // Population
        //public float TotalPopulation { get; set; }
        //public float PopulationGrowth { get; set; }
    }
}