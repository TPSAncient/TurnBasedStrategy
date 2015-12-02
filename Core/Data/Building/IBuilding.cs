using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.Building
{
    public interface IBuilding
    {
        List<string> BuildingTag { get; set; }

        [JsonIgnore]
        StaticDictionary<StaticBuilding> ListOfCompleteBuilding { get; set; }
        [JsonIgnore]
        StaticDictionary<StaticBuilding> ListOfUnderConstructionBuilding { get; set; }
        [JsonIgnore]
        StaticDictionary<StaticBuilding> ListOfPotentialBuilding { get; set; }
    }
}
