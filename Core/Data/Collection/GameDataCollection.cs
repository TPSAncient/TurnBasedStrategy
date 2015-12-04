using System.Collections.Generic;
using Core.Data.Actor;
using Core.Data.Building;
using Core.Data.Common;
using Core.Data.World.Country;

namespace Core.Data.Collection
{
    public class GameDataCollection
    {
        // List of all buildings
        public IDataDictionary<StaticBuilding> AllBuildings { get; set; } 
        // List of all Countrys ??
        public IDataDictionary<GameCountry> Countrys { get; set; }

        public StaticDictionary<GameActor> Actores { get; set; }

        public GameActor Player { get; set; } 
    }
}