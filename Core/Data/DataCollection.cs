using Core.Data.World;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;

namespace Core.Data
{
    public class DataCollection
    {
        public IDataDictionary<StaticPlayer> Players { get; set; } = new StaticDictionary<StaticPlayer>();
        public IDataDictionary<StaticCountry> Countries { get; set; } = new StaticDictionary<StaticCountry>();
        public IDataDictionary<StaticProvince> Provinces { get; set; } = new StaticDictionary<StaticProvince>();
        public IDataDictionary<StaticRegion> Regions { get; set; } = new StaticDictionary<StaticRegion>();
        public IDataDictionary<StaticCity> Citys { get; set; } = new StaticDictionary<StaticCity>();
        public IDataDictionary<StaticFarm> Farms { get; set; } = new StaticDictionary<StaticFarm>();
        public IDataDictionary<StaticPort> Ports { get; set; } = new StaticDictionary<StaticPort>();
    }
}