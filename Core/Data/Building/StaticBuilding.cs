using System;
using System.Collections.Generic;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.Building
{
    public class StaticBuilding : IData
    {
        #region IData implementation

        public int Id { get; set; }
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
        public float GoldCost { get; set; }
        // Building maintainence
        public float Maintenance { get; set; }


        public bool IsBuilt { get; set; }
        public bool StartBuilding { get; set; }
        public int BuildTime { get; set; }
        public int RemainingBuildTime { get; set; }

    }
}
