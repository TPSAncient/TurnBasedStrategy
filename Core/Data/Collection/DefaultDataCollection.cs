using Core.Data.Actor;
using Core.Data.Building;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.Data.World.Region.City;
using Core.Data.World.Region.Farm;
using Core.Data.World.Region.Industry;
using Core.Data.World.Region.Infrastructure;
using Core.Data.World.Region.Port;

namespace Core.Data.Collection
{
    public class DefaultDataCollection
    {
        public IDataDictionary<StaticActor> Players { get; set; } = new StaticDictionary<StaticActor>();
        public IDataDictionary<StaticCountry> Countries { get; set; } = new StaticDictionary<StaticCountry>();
        public IDataDictionary<StaticProvince> Provinces { get; set; } = new StaticDictionary<StaticProvince>();
        public IDataDictionary<StaticRegion> Regions { get; set; } = new StaticDictionary<StaticRegion>();
        public IDataDictionary<StaticCity> Citys { get; set; } = new StaticDictionary<StaticCity>();
        public IDataDictionary<StaticFarm> Farms { get; set; } = new StaticDictionary<StaticFarm>();
        public IDataDictionary<StaticPort> Ports { get; set; } = new StaticDictionary<StaticPort>();
        public IDataDictionary<StaticInfrastructure> Infrastructures { get; set; } = new StaticDictionary<StaticInfrastructure>();
        public IDataDictionary<StaticIndustry> Industries { get; set; } = new StaticDictionary<StaticIndustry>();

        public IDataDictionary<StaticBuilding> Buildings { get; set; } = new StaticDictionary<StaticBuilding>(); 
    }
}