namespace Core.Data.World.Location
{
    public class StaticSettlement : IData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DataType DataType { get; set; }
    }
}
