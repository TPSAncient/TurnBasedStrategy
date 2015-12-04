using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Farm
{
    public class GameFarm : StaticFarm, IGameBuilding
    {
        public GameFarm() { }
        public GameFarm(StaticFarm farm) : base(farm) { }

        public IDataDictionary<GameBuilding> ListOfCompleteBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfUnderConstructionBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfPotentialBuilding { get; set; }
    }
}