using System.Collections.Generic;
using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Industry
{
    public class StaticIndustry : IData, IBuilding
    {
        public StaticIndustry()
        {
        }

        public StaticIndustry(StaticIndustry industry)
        {
            Name = industry.Name;
            TagName = industry.TagName;
            DataType = industry.DataType;
            BuildingTag = industry.BuildingTag;
        }

        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }


        #region IBuilding

        public List<string> BuildingTag { get; set; }
        

        #endregion
    }
}
