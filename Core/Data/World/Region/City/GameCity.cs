using Core.Data.Building;
using Core.Data.Common;
using Newtonsoft.Json;

namespace Core.Data.World.Region.City
{
    public class GameCity : StaticCity, IGameBuilding
    {
        public GameCity()
        {
        }

        public GameCity(StaticCity city) : base(city)
        {
        }

        public IDataDictionary<GameBuilding> ListOfCompleteBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfUnderConstructionBuilding { get; set; }
        public IDataDictionary<GameBuilding> ListOfPotentialBuilding { get; set; }
    }
}