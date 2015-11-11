using Core.Data.Common;

namespace Core.Data.Building
{
    public class StaticBuilding : IData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }
        // Building Type
        public StaticBuildingType BuildingType { get; set; }

        public bool IsBuilt { get; set; }
        // Building requirment
        public float Cost { get; set; }
        // Building maintainence
        public float Maintenance { get; set; }
        // Where can you build buildings
    }
}
