using Core.Data.Common;
using Core.Data.World.Province;
using Core.Data.World.Region;

namespace Core.Data.World.Country
{
    public class GameCountry : StaticCountry
    {
        public GameCountry(StaticCountry country) : base(country) { }
        public StaticDictionary<GameProvince> Provinces { get; set; } = new StaticDictionary<GameProvince>();

        public StaticDictionary<GameRegion> Regions { get; set; } = new StaticDictionary<GameRegion>();

        // Armys that Country own


    }
}