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
        public StaticRegion()
        {
        }

        public StaticRegion(StaticRegion region)
        {
            Name = region.Name;
            DataType = region.DataType;
            TagName = region.TagName;
            Player = region.Player;
            ProvinceTag = region.ProvinceTag;
            CityTag = region.CityTag;
            FarmTag = region.FarmTag;
            PortTag = region.PortTag;
            InfrastructureTag = region.InfrastructureTag;
            IndustryTag = region.IndustryTag;
            CanBuildPort = region.CanBuildPort;
            CountryTag = region.CountryTag;
        }

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
        public string CountryTag { get; set; }
        

        // Population
        //public float TotalPopulation { get; set; }
        //public float PopulationGrowth { get; set; }
    }
}