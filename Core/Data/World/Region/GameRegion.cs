using Core.Data.World.Region.City;
using Core.Data.World.Region.Farm;
using Core.Data.World.Region.Industry;
using Core.Data.World.Region.Infrastructure;
using Core.Data.World.Region.Port;

namespace Core.Data.World.Region
{
    public class GameRegion : StaticRegion
    {
        public GameRegion()
        {
        }

        public GameRegion(StaticRegion region) : base(region)
        {
        }

        public GameCity City { get; set; }
        public GameFarm Farm { get; set; }
        public GamePort Port { get; set; }
        public GameInfrastructure Infrastructure { get; set; }
        public GameIndustry Industry { get; set; }
    }
}