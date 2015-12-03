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

            building = AddBuilding("Wooden Palisade", "building_woodenpalisade", StaticBuildingType.Defensive, 100, 10, 2);
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Wooden Walls", "building_woodenwalls", StaticBuildingType.Defensive, 200, 20, 2);
            building = AddBuildingPrerequisites(building, "building_woodenpalisade", "building_woodenpalisade");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Stone Walls", "building_stonewalls", StaticBuildingType.Defensive, 400, 40, 2);
            building = AddBuildingPrerequisites(building, "building_woodenwalls", "building_woodenpalisade", "building_woodenwalls");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Large Stone Walls", "building_largestonewalls", StaticBuildingType.Defensive, 800, 80, 2);
            building = AddBuildingPrerequisites(building, "building_stonewalls", "building_woodenpalisade", "building_woodenwalls", "building_stonewalls");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Huge Stone Walls", "building_hugestonewalls", StaticBuildingType.Defensive, 1500, 150, 2);
            building = AddBuildingPrerequisites(building, "building_largestonewalls", "building_woodenpalisade", 
                "building_woodenwalls", "building_stonewalls", "building_largestonewalls");
            Buildings.Add(building.TagName, building);
        }

        private void SeedInfrastructureData()
        {
            StaticBuilding building;

            building = AddBuilding("Path", "building_path", StaticBuildingType.Infrastructure, 100, 10, 2);
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Road", "building_road", StaticBuildingType.Infrastructure, 200, 20, 2);
            building = AddBuildingPrerequisites(building, "building_path", "building_path");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Paved Road", "building_pavedroad", StaticBuildingType.Infrastructure, 400, 40, 2);
            building = AddBuildingPrerequisites(building, "building_road", "building_path", "building_road");
            Buildings.Add(building.TagName, building);

            building = AddBuilding("Highways", "building_highways", StaticBuildingType.Infrastructure, 800, 80, 2);
            building = AddBuildingPrerequisites(building, "building_pavedroad", "building_path", "building_road", "building_pavedroad");
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