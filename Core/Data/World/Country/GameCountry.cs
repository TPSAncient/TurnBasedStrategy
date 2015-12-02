using System.Collections.Generic;
using Core.Data.World.Province;
using Newtonsoft.Json;

namespace Core.Data.World.Country
{
    public class GameCountry : StaticCountry
    {
        [JsonIgnore]
        public List<StaticProvince> Provinces { get; set; } = new List<StaticProvince>();
    }
}