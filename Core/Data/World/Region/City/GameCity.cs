using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.City
{
    public class GameCity : StaticCity
    {
        public GameCity()
        {
        }

        public GameCity(StaticCity city) : base(city)
        {
        }

        public StaticDictionary<StaticBuilding> ListOfCompleteBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfUnderConstructionBuilding { get; set; }
        public StaticDictionary<StaticBuilding> ListOfPotentialBuilding { get; set; }
    }
}