using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.Industry
{
    public class GameIndustry : StaticIndustry
    {
        public GameIndustry()
        {
        }

        public GameIndustry(StaticIndustry industry) : base(industry) { }

        public StaticDictionary<StaticBuilding> ListOfCompleteBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfUnderConstructionBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfPotentialBuilding { get; set; }
    }
}