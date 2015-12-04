using Core.Data.Common;

namespace Core.Data.Building
{
    public interface IGameBuilding
    {
        IDataDictionary<GameBuilding> ListOfCompleteBuilding { get; set; }
        IDataDictionary<GameBuilding> ListOfUnderConstructionBuilding { get; set; }
        IDataDictionary<GameBuilding> ListOfPotentialBuilding { get; set; }
    }
}