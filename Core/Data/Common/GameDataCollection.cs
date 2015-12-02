using System.Collections.Generic;
using Core.Data.Building;
using Core.Data.World.Country;

namespace Core.Data.Common
{
    public class GameDataCollection
    {
        // List of all buildings
        public StaticDictionary<StaticBuilding> AllBuildings { get; set; } 
        // List of all Countrys ??
        public List<GameCountry> Countrys { get; set; } 
         
    }
}