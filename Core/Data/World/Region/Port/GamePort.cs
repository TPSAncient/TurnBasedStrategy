using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Port
{
    public class GamePort : StaticPort
    {
        public GamePort()
        {
        }

        public GamePort(StaticPort port) : base(port)
        {
        }

        public StaticDictionary<StaticBuilding> ListOfCompleteBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfUnderConstructionBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfPotentialBuilding { get; set; }
    }
}