namespace Core.Data.World.Location
{
    public class StaticCity : ILocation
    {
        // General
        public int Id { get; set; }
        public string Name { get; set; }
        public LocationType LocationType { get; set; }

        // Spesific
        public int PopulationCount { get; set; }
        public int PopulationBirthRate { get; set; }
        public int PopulationImmigrationRate { get; set; }
        // Building List
        
    }
}
