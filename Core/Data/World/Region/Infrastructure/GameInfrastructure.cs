using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Infrastructure
{
    public class GameInfrastructure : StaticInfrastructure
    {
        public GameInfrastructure()
        {
        }

        public GameInfrastructure(StaticInfrastructure infrastructure) : base(infrastructure)
        {
        }

        public StaticDictionary<StaticBuilding> ListOfCompleteBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfUnderConstructionBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfPotentialBuilding { get; set; }
    }
}