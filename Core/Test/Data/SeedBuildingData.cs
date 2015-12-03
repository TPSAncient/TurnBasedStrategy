using System.Collections.Generic;
using System.Linq;
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
            Buildings = new StaticDictionary<StaticBuilding>();

            SeedInfrastructureData();
        }

        private void SeedInfrastructureData()
        {
            StaticBuilding building;

            building = AddBuilding("Path", "building_path", StaticBuildingType.Infrastructure, 100, 10, 2);
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Road", "building_road", StaticBuildingType.Infrastructure, 200, 20, 2);
            building = AddBuildingPrerequisites(building, "building_path", "building_path");
            Buildings.Add(building.TagName, building);

        }

        private StaticBuilding AddBuilding(string name, string tagName, StaticBuildingType buildingType, float goldCost, float maintance, int buildTime)
        {
            StaticBuilding building = new StaticBuilding();
            building.Name = name;
            building.TagName = tagName;
            building.DataType = DataType.Building;
            building.BuildingType = buildingType;
            
            building.DefaultGoldCost = goldCost;
            building.DefaultMaintenance = maintance;
            building.DefaultBuildTime = buildTime;

            return building;
        }

        private StaticBuilding AddBuildingPrerequisites(StaticBuilding building, string upgradesFrom, params string[] prerequisites)
        {
            building.UpgradesFrom = upgradesFrom;
            building.Prerequisites = prerequisites.ToList();
            
            return building;
        }
    }
}