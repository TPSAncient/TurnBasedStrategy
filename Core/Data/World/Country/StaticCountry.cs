using Core.Data.Common;

namespace Core.Data.World.Country
{
    public class StaticCountry : IData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DataType DataType { get; set; }
        public string TagName { get; set; }
    }
}