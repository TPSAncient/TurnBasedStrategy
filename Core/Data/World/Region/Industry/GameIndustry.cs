using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Industry
{
    public class GameIndustry : StaticIndustry, IGameBuilding
    {
        public GameIndustry()
        {
        }

        public GameIndustry(StaticIndustry industry) : base(industry) { }

        public IDataDictionary<GameBuilding> ListOfCompleteBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfUnderConstructionBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfPotentialBuilding { get; set; }
    }
}