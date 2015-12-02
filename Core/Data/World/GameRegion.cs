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
    }
}