using System.Collections.Generic;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Country
{
    public class StaticCountry : IData
    {
        public StaticCountry()
        {
        }

        public StaticCountry(StaticCountry country)
        {
            Name = country.Name;
            DataType = country.DataType;
            TagName = country.TagName;
        }

        #region IData

        public string Name { get; set; }
        public DataType DataType { get; set; }
        public string TagName { get; set; }

        #endregion

        //public List<string> TagProvinces { get; set; } = new List<string>();
    }
}