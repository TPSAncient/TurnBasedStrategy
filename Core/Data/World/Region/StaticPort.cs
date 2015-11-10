namespace Core.Data.World.Region
{
    public class StaticPort : IData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DataType DataType { get; set; }
        public string TagName { get; set; }
    }
}
