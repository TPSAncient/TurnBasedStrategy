using System;
using System.Collections.Generic;
using System.Globalization;
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
            UpgradesTo = building.UpgradesTo;
            DefaultGoldCost = building.DefaultGoldCost;
            DefaultMaintenance = building.DefaultMaintenance;
            DefaultBuildTime = building.DefaultBuildTime;
            BuildingChain = building.BuildingChain;
        }

        #region IData implementation

        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }

        #endregion

        // Building Type
        public StaticBuildingType BuildingType { get; set; }

        public RequiredEnum RequiredEnum { get; set; }

        public List<string> Prerequisites { get; set; } = new List<string>();

        public List<string> Modifiers { get; set; } = new List<string>(); 

        public string BuildingChain { get; set; }
        public string UpgradesFrom { get; set; }
        public string UpgradesTo { get; set; }
        public float DefaultGoldCost { get; set; }
        public float DefaultMaintenance { get; set; }
        public int DefaultBuildTime { get; set; }
        
    }
}
