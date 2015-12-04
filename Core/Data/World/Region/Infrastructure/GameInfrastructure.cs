using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Infrastructure
{
    public class GameInfrastructure : StaticInfrastructure, IGameBuilding
    {
        public GameInfrastructure()
        {
        }

        public GameInfrastructure(StaticInfrastructure infrastructure) : base(infrastructure)
        {
        }

        public IDataDictionary<GameBuilding> ListOfCompleteBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfUnderConstructionBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfPotentialBuilding { get; set; }
    }
}