namespace Core.Data.World.Location
{
    public class StaticFarm : IData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }
    }
}
