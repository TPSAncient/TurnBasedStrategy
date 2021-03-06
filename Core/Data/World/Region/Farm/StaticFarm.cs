﻿using System.Collections.Generic;
using Core.Data.Building;
using Core.Data.Common;

namespace Core.Data.World.Region.Farm
{
    public class StaticFarm : IData, IBuilding
    {
        public StaticFarm() { }

        public StaticFarm(StaticFarm farm)
        {
            Name = farm.Name;
            TagName = farm.TagName;
            DataType = farm.DataType;
            BuildingTag = farm.BuildingTag;
        }

        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }

        #region IBuilding

        public List<string> BuildingTag { get; set; } = new List<string>();
        

        #endregion
    }
}
