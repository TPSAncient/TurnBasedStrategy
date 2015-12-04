using System;
using System.Collections.Generic;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.Building
{
    public class StaticBuilding : IData
    {
        public StaticBuilding()
        {
        }

        public StaticBuilding(StaticBuilding building)
        {
            Name = building.Name;
            TagName = building.TagName;
            DataType = building.DataType;
            BuildingType = building.BuildingType;
            Prerequisites = building.Prerequisites;
            Modifiers = building.Modifiers;
            UpgradesFrom = building.UpgradesFrom;
            DefaultGoldCost = building.DefaultGoldCost;
            DefaultMaintenance = building.DefaultMaintenance;
            DefaultBuildTime = building.DefaultBuildTime;
        }
        #region IData implementation

        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }

        #endregion

        // Building Type
        public StaticBuildingType BuildingType { get; set; }

        public List<string> Prerequisites { get; set; } = new List<string>();

        public List<string> Modifiers { get; set; } = new List<string>(); 

        public string UpgradesFrom { get; set; }
        // Building requirment
        public float DefaultGoldCost { get; set; }
        // Building maintainence
        public float DefaultMaintenance { get; set; }
        public int DefaultBuildTime { get; set; }
        
    }
}
