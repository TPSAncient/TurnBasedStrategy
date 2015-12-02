﻿using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Industry
{
    public class GameIndustry : StaticIndustry
    {
        [JsonIgnore]
        public StaticDictionary<StaticBuilding> ListOfCompleteBuilding { get; set; }
        [JsonIgnore]
        public StaticDictionary<StaticBuilding> ListOfUnderConstructionBuilding { get; set; }
        [JsonIgnore]
        public StaticDictionary<StaticBuilding> ListOfPotentialBuilding { get; set; }
    }
}