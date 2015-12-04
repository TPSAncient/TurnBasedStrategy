using System.Collections.Generic;
using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Port
{
    public class StaticPort : IData, IBuilding
    {
        public StaticPort()
        {
        }

        public StaticPort(StaticPort port)
        {
            Name = port.Name;
            TagName = port.TagName;
            DataType = port.DataType;
            BuildingTag = port.BuildingTag;
        }

        public string Name { get; set; }
        public DataType DataType { get; set; }
        public string TagName { get; set; }

        #region IBuilding

        public List<string> BuildingTag { get; set; }
        

        #endregion
    }
}
