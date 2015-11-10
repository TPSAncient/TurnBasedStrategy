using Core.Data.World.Location;
using Newtonsoft.Json;

namespace Core.Data.World
{
    public class StaticRegion : IData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DataType DataType { get; set; }

        public string TagName { get; set; }

        public int Player { get; set; }

        public string ProvinceTag { get; set; }
        // Only one may be in region
        public string CityTag { get; set; }
        public string FarmTag { get; set; }
        public string PortTag { get; set; }
   
        public bool CanBuildPort { get; set; }

        [JsonIgnore]
        public StaticCity City { get; set; }
        [JsonIgnore]
        public StaticFarm Farm { get; set; }
        [JsonIgnore]
        public StaticPort Port { get; set; }

        //public StaticIndustry Industry { get; set; }
        //public StaticPort Port { get; set; }

        // Population
        //public float TotalPopulation { get; set; }
        //public float PopulationGrowth { get; set; }

    }
}