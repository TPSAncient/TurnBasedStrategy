﻿using System;
using System.Collections.Generic;
using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.City
{
    [Serializable]
    public class StaticCity : IData, IBuilding
    {
        public StaticCity()
        {
        }

        public StaticCity(StaticCity city)
        {
            Name = city.Name;
            TagName = city.TagName;
            DataType = city.DataType;
            BuildingTag = city.BuildingTag;
        }


        // General
        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }

        #region IBuilding

        public List<string> BuildingTag { get; set; } = new List<string>();
        

        #endregion


    }
}
