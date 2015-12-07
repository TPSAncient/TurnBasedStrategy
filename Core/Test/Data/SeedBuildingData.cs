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
            SeedDefensiveData();
        }

        private void SeedDefensiveData()
        {
            StaticBuilding building;

            building = AddBuilding("Wooden Palisade", "building_woodenpalisade", StaticBuildingType.Defensive, RequiredEnum.City,  100, 10, 2);
            building = AddBuildingPrerequisites(building, "", "building_woodenwalls", "buildingchain_wall");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Wooden Walls", "building_woodenwalls", StaticBuildingType.Defensive, RequiredEnum.City, 200, 20, 2);
            building = AddBuildingPrerequisites(building, "building_woodenpalisade", "building_stonewalls", "buildingchain_wall");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Stone Walls", "building_stonewalls", StaticBuildingType.Defensive, RequiredEnum.City, 400, 40, 2);
            building = AddBuildingPrerequisites(building, "building_woodenwalls", "building_largestonewalls", "buildingchain_wall");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Large Stone Walls", "building_largestonewalls", StaticBuildingType.Defensive, RequiredEnum.City, 800, 80, 2);
            building = AddBuildingPrerequisites(building, "building_stonewalls", "building_hugestonewalls", "buildingchain_wall");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Huge Stone Walls", "building_hugestonewalls", StaticBuildingType.Defensive, RequiredEnum.City, 1500, 150, 2);
            building = AddBuildingPrerequisites(building, "building_largestonewalls", "", "buildingchain_wall");
            Buildings.Add(building.TagName, building);
        }

        private void SeedInfrastructureData()
        {
            StaticBuilding building;

            building = AddBuilding("Path", "building_path", StaticBuildingType.Infrastructure, RequiredEnum.Infrastructure, 100, 10, 2);
            building = AddBuildingPrerequisites(building, "", "building_road", "buildingchain_road");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Road", "building_road", StaticBuildingType.Infrastructure, RequiredEnum.Infrastructure, 200, 20, 2);
            building = AddBuildingPrerequisites(building, "building_path", "building_pavedroad", "buildingchain_road");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Paved Road", "building_pavedroad", StaticBuildingType.Infrastructure, RequiredEnum.Infrastructure, 400, 40, 2);
            building = AddBuildingPrerequisites(building, "building_road", "building_highways", "buildingchain_road");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Highways", "building_highways", StaticBuildingType.Infrastructure, RequiredEnum.Infrastructure, 800, 80, 2);
            building = AddBuildingPrerequisites(building, "building_pavedroad", "", "buildingchain_road");
            Buildings.Add(building.TagName, building);

        }

        private StaticBuilding AddBuilding(string name, string tagName, StaticBuildingType buildingType, RequiredEnum requiredEnum, float goldCost, float maintance, int buildTime)
        {
            StaticBuilding building = new StaticBuilding();
            building.Name = name;
            building.TagName = tagName;
            building.DataType = DataType.Building;
            building.BuildingType = buildingType;
            building.RequiredEnum = requiredEnum;
            
            building.DefaultGoldCost = goldCost;
            building.DefaultMaintenance = maintance;
            building.DefaultBuildTime = buildTime;

            return building;
        }

        private StaticBuilding AddBuildingPrerequisites(StaticBuilding building, string upgradesFrom, string upgradesTo, string buildingChain)
        {
            building.UpgradesFrom = upgradesFrom;
            building.UpgradesFrom = upgradesTo;
            building.BuildingChain = buildingChain;
            //building.Prerequisites = prerequisites.ToList();
            
            return building;
        }
    }
}