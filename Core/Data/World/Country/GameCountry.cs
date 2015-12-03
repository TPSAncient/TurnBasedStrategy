using Core.Data.Common;
using Core.Data.World.Province;

namespace Core.Data.World.Country
{
    public class GameCountry : StaticCountry
    {
        public StaticDictionary<GameProvince> Provinces { get; set; } = new StaticDictionary<GameProvince>();

        public StaticDictionary<GameRegion> Regions { get; set; } = new StaticDictionary<GameRegion>();
    }
}