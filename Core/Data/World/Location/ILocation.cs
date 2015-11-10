namespace Core.Data.World.Location
{
    public interface ILocation
    {
        int Id { get; set; }
        string Name { get; set; }
        DataType DataType { get; set; }
    }
}
