using System.Collections.Generic;
using Core.Data.Building;
using Core.Data.Common;

namespace Core.Data.World.Region.Infrastructure
{
    public class StaticInfrastructure : IData, IBuilding
    {
        public StaticInfrastructure()
        {
        }

        public StaticInfrastructure(StaticInfrastructure infrastructure)
        {
            Name = infrastructure.Name;
            TagName = infrastructure.TagName;
            DataType = infrastructure.DataType;
            BuildingTag = infrastructure.BuildingTag;
        }

        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }

        #region IBuilding

        public List<string> BuildingTag { get; set; } = new List<string>();
        

        #endregion
    }
}
