using Core.Data.World.Location;

namespace Core.Data.World
{
    public class StaticRegion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TagName { get; set; }

        public int Player { get; set; }

        public string Province { get; set; }
        // Only one may be in region
        public string City { get; set; }
        //public StaticSettlement Settlement { get; set; }
        

        //public StaticFarm Farm { get; set; }
        //public StaticIndustry Industry { get; set; }
        //public StaticPort Port { get; set; }

        // Population
        //public float TotalPopulation { get; set; }
        //public float PopulationGrowth { get; set; }

    }
}