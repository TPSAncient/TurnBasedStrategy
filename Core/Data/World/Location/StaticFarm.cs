namespace Core.Data.World.Location
{
    public class StaticFarm : ILocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LocationType LocationType { get; set; }
    }
}
