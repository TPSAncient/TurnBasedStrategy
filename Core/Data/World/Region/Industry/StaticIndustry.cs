using System.Collections.Generic;
using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Industry
{
    public class StaticIndustry : IData, IBuilding
    {
        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }


        #region IBuilding

        public List<string> BuildingTag { get; set; }
        

        #endregion
    }
}
