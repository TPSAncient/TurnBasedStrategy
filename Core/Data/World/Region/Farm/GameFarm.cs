using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Farm
{
    public class GameFarm : StaticFarm
    {
        public GameFarm() { }
        public GameFarm(StaticFarm farm) : base(farm) { }

        public StaticDictionary<StaticBuilding> ListOfCompleteBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfUnderConstructionBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfPotentialBuilding { get; set; }
    }
}