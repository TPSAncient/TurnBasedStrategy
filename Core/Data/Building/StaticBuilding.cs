using System;
using System.Collections.Generic;
using Core.Data.Common;
using Newtonsoft.Json;

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

        public List<string> Prerequisites { get; set; } = new List<string>();

        public string UpgradesFrom { get; set; }

        public bool IsBuilt { get; set; }
        // Building requirment
        public float GoldCost { get; set; }
        // Building maintainence
        public float Maintenance { get; set; }
        // Where can you build buildings
    }
}
