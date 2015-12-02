using System.Threading;
using Core.Data.Building;
using Core.Data.Common;

namespace Core.Test.Data
{
    public class SeedBuildingData
    {
        public StaticDictionary<StaticBuilding> Buildings;

        public SeedBuildingData()
        {
            
        }

        public void AddBuilding()
        {
            StaticBuilding building = new StaticBuilding();
            building.Id = 1;
            building.Name = "Path";
            building.TagName = "building_path";
            building.DataType = DataType.Building;
            building.BuildingType = StaticBuildingType.Infrastructure;
            
            building.DefaultGoldCost = 100;
            building.DefaultMaintenance = 10;
            building.DefaultBuildTime = 2;
        }
    }
}