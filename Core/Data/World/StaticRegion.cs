using Core.Data.World.Location;

namespace Core.Data.World
{
    public class StaticRegion
    {
        // Only one may be in region
        public StaticCity City { get; set; }
        public StaticSettlement Settlement { get; set; }
        

        public StaticFarm Farm { get; set; }
        public StaticIndustry Industry { get; set; }
        public StaticPort Port { get; set; }
        
    }
}