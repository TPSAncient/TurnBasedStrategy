using Core.Data.Common;
using Core.Data.World.Region.City;
using Core.Data.World.Region.Farm;
using Core.Data.World.Region.Industry;
using Core.Data.World.Region.Infrastructure;
using Core.Data.World.Region.Port;
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

        

        // Population
        //public float TotalPopulation { get; set; }
        //public float PopulationGrowth { get; set; }
    }
}