using System.Collections.Generic;
using Core.Data.Common;

namespace Core.Data.World.Country
{
    public class StaticCountry : IData
    {
        #region IData

        public string Name { get; set; }
        public DataType DataType { get; set; }
        public string TagName { get; set; }

        #endregion

        //public List<string> TagProvinces { get; set; } = new List<string>();
    }
}