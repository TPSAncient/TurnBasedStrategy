using System.Collections.Generic;
using Core.Data.Common;
using Core.Data.World.Province;
using Newtonsoft.Json;

namespace Core.Data.World.Country
{
    public class StaticCountry : IData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DataType DataType { get; set; }
        public string TagName { get; set; }




        public List<string> TagProvinces { get; set; } = new List<string>();
            // Data that game needs
        [JsonIgnore]
        public List<StaticProvince> Provinces { get; set; } = new List<StaticProvince>();
    }
}