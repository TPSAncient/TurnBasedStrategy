using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Port
{
    public class GamePort : StaticPort, IGameBuilding
    {
        public GamePort()
        {
        }

        public GamePort(StaticPort port) : base(port)
        {
        }

        public IDataDictionary<GameBuilding> ListOfCompleteBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfUnderConstructionBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfPotentialBuilding { get; set; }
    }
}