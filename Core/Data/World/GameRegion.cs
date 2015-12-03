using Core.Data.World.Region;
using Core.Data.World.Region.City;
using Core.Data.World.Region.Farm;
using Core.Data.World.Region.Industry;
using Core.Data.World.Region.Infrastructure;
using Core.Data.World.Region.Port;
using Newtonsoft.Json;

namespace Core.Data.World
{
    public class GameRegion : StaticRegion
    {
        public GameCity City { get; set; }
        public GameFarm Farm { get; set; }
        public GamePort Port { get; set; }
        public GameInfrastructure Infrastructure { get; set; }
        public GameIndustry Industry { get; set; }
    }
}