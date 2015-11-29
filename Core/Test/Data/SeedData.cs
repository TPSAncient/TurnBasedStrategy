using System.Collections.Generic;
using Core.Data.Actor;
using Core.Data.Building;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System;

namespace Core.Test.Data
{
    public class SeedData
    {
        private readonly DataManager _dataManager;
        public DataCollection DataCollection { get; set; } = new DataCollection();
        public string Path { get; set; }

        public SeedData(DataManager dataManager)
        {
            _dataManager = dataManager;

            SeedPlayerData();
            SeedCountriesData();
            SeedProvincesData();
            SeedRegionsData();
            SeedCitiesData();
            SeedFarmsData();
            SeedPortsData();
            SeedInfrastructureData();
            SeedIndustryData();
            SeedBuildingsData();
        }

        public void SeedPlayerData()
        {
            StaticActor actor = new StaticActor { IsPlayer = true };

            DataCollection.Players.DataType = DataType.None;
            DataCollection.Players.Add("1", actor);
        }

        public void SeedCountriesData()
        {
            StaticCountry country = new StaticCountry();
            country.Id = 1;
            country.Name = "Rome";
            country.TagName = "country_rome";
            country.DataType = DataType.Country;
            country.TagProvinces.Add("province_italia");
            DataCollection.Countries.DataType = DataType.Country;
            DataCollection.Countries.Add(country.TagName, country);
        }

        public void SeedProvincesData()
        {
            StaticProvince province = new StaticProvince
            {
                Id = 1,
                Name = "Italia",
                TagName = "province_italia",
                DataType = DataType.Province
            };

            DataCollection.Provinces.DataType = DataType.Province;
            DataCollection.Provinces.Add(province.TagName, province);
        }

        public void SeedRegionsData()
        {
            StaticRegion regionRoma = new StaticRegion();
            regionRoma.Id = 1;
            regionRoma.Name = "Roma";
            regionRoma.CityTag = "city_roma";
            regionRoma.FarmTag = "farm_roma";
            regionRoma.PortTag = "port_roma";
            regionRoma.InfrastructureTag = "infrastructure_roma";
            regionRoma.CanBuildPort = true;
            regionRoma.ProvinceTag = "province_italia";
            regionRoma.TagName = "region_roma";
            regionRoma.Player = 1;
            regionRoma.DataType = DataType.Region;

            StaticRegion regionVelathria = new StaticRegion();
            regionVelathria.Id = 2;
            regionVelathria.Name = "Velathri";
            regionVelathria.CityTag = "city_velathri";
            regionVelathria.FarmTag = "farm_velathri";
            regionVelathria.PortTag = "port_velathri";
            regionVelathria.InfrastructureTag = "infrastructure_velathri";
            regionVelathria.CanBuildPort = true;
            regionVelathria.ProvinceTag = "province_italia";
            regionVelathria.TagName = "region_velathria";
            regionVelathria.Player = 1;
            regionVelathria.DataType = DataType.Region;

            StaticRegion regionAriminum = new StaticRegion();
            regionAriminum.Id = 3;
            regionAriminum.Name = "Ariminum";
            regionAriminum.CityTag = "city_ariminum";
            regionAriminum.FarmTag = "farm_ariminum";
            regionAriminum.PortTag = "port_ariminum";
            regionAriminum.InfrastructureTag = "infrastructure_ariminum";
            regionAriminum.CanBuildPort = true;
            regionAriminum.ProvinceTag = "province_italia";
            regionAriminum.TagName = "region_ariminum";
            regionAriminum.Player = 1;
            regionAriminum.DataType = DataType.Region;

            DataCollection.Regions.DataType = DataType.Region;
            DataCollection.Regions.Add(regionRoma.TagName, regionRoma);
            DataCollection.Regions.Add(regionVelathria.TagName, regionVelathria);
            DataCollection.Regions.Add(regionAriminum.TagName, regionAriminum);
        }

        public void SeedCitiesData()
        {
            StaticCity cityRoma = new StaticCity();
            cityRoma.Id = 1;
            cityRoma.Name = "Roma";
            cityRoma.DataType = DataType.City;
            cityRoma.TagName = "city_roma";
            

            StaticCity cityVelathri = new StaticCity();
            cityVelathri.Id = 2;
            cityVelathri.Name = "Velathri";
            cityVelathri.DataType = DataType.City;
            cityVelathri.TagName = "city_velathri";
            

            StaticCity cityArminum = new StaticCity();
            cityArminum.Id = 3;
            cityArminum.Name = "Ariminum";
            cityArminum.DataType = DataType.City;
            cityArminum.TagName = "city_ariminum";

            DataCollection.Citys.DataType = DataType.City;
            DataCollection.Citys.Add(cityRoma.TagName, cityRoma);
            DataCollection.Citys.Add(cityVelathri.TagName, cityVelathri);
            DataCollection.Citys.Add(cityArminum.TagName, cityArminum);
        }

        public void SeedFarmsData()
        {
            StaticFarm farmRoma = new StaticFarm();
            farmRoma.Id = 1;
            farmRoma.Name = "Roma Farm";
            farmRoma.TagName = "farm_roma";
            farmRoma.DataType = DataType.Farm;

            StaticFarm farmVelathri = new StaticFarm();
            farmVelathri.Id = 2;
            farmVelathri.Name = "Velathri Farm";
            farmVelathri.TagName = "farm_velathri";
            farmVelathri.DataType = DataType.Farm;

            StaticFarm farmAriminum = new StaticFarm();
            farmAriminum.Id = 3;
            farmAriminum.Name = "Ariminum Farm";
            farmAriminum.TagName = "farm_ariminum";
            farmAriminum.DataType = DataType.Farm;

            DataCollection.Farms.DataType = DataType.Farm;
            DataCollection.Farms.Add("farm_roma", farmRoma);
            DataCollection.Farms.Add("farm_velathri", farmVelathri);
            DataCollection.Farms.Add("farm_ariminum", farmAriminum);
        }

        public void SeedPortsData()
        {
            StaticPort portRoma = new StaticPort();
            portRoma.Id = 1;
            portRoma.Name = "Roma port";
            portRoma.DataType = DataType.Port;
            portRoma.TagName = "port_roma";

            StaticPort portVelathri = new StaticPort();
            portVelathri.Id = 2;
            portVelathri.Name = "Velathri port";
            portVelathri.DataType = DataType.Port;
            portVelathri.TagName = "port_velathri";

            StaticPort portAriminum = new StaticPort();
            portAriminum.Id = 3;
            portAriminum.Name = "Ariminum port";
            portAriminum.DataType = DataType.Port;
            portAriminum.TagName = "port_ariminum";

            DataCollection.Ports.DataType = DataType.Port;
            DataCollection.Ports.Add("port_roma", portRoma);
            DataCollection.Ports.Add("port_velathri", portRoma);
            DataCollection.Ports.Add("port_ariminum", portRoma);
        }

        public void SeedInfrastructureData()
        {
            StaticInfrastructure infrastructureRoma = new StaticInfrastructure();
            infrastructureRoma.Id = 1;
            infrastructureRoma.Name = "Infra Roma";
            infrastructureRoma.DataType = DataType.Infrastructure;
            infrastructureRoma.TagName = "infrastructure_roma";
            infrastructureRoma.BuildingTag.Add("building_road");

            StaticInfrastructure infrastructureVelathri = new StaticInfrastructure
            {
                Id = 2,
                Name = "Infra Velathri",
                DataType = DataType.Infrastructure,
                TagName = "infrastructure_velathri"
            };

            StaticInfrastructure infrastructureAriminum = new StaticInfrastructure
            {
                Id = 3,
                Name = "Infra Ariminum",
                DataType = DataType.Infrastructure,
                TagName = "infrastructure_ariminum"
            };

            DataCollection.Infrastructures.Add(infrastructureRoma.TagName, infrastructureRoma);
            DataCollection.Infrastructures.Add(infrastructureVelathri.TagName, infrastructureVelathri);
            DataCollection.Infrastructures.Add(infrastructureAriminum.TagName, infrastructureAriminum);
        }

        public void SeedIndustryData()
        {
            StaticIndustry industryRoma = new StaticIndustry();
            industryRoma.Id = 1;
            industryRoma.DataType = DataType.Industry;
            industryRoma.Name = "Roma Industry";
            industryRoma.TagName = "industry_roma";
            industryRoma.BuildingTag = new List<string>();

            StaticIndustry industryVelathri = new StaticIndustry();
            industryVelathri.Id = 2;
            industryVelathri.DataType = DataType.Industry;
            industryVelathri.Name = "Velathri Industry";
            industryVelathri.TagName = "industry_velathri";
            industryVelathri.BuildingTag = new List<string>();

            StaticIndustry industryAriminum = new StaticIndustry();
            industryAriminum.Id = 3;
            industryAriminum.DataType = DataType.Industry;
            industryAriminum.Name = "Ariminum Industry";
            industryAriminum.TagName = "industry_ariminum";
            industryAriminum.BuildingTag = new List<string>();

            DataCollection.Industries.DataType = DataType.Industry;
            DataCollection.Industries.Data.Add(industryRoma.TagName, industryRoma);
            DataCollection.Industries.Data.Add(industryVelathri.TagName, industryVelathri);
            DataCollection.Industries.Data.Add(industryAriminum.TagName, industryAriminum);
        }

        public void SeedBuildingsData()
        {
            StaticBuilding pathBuilding = new StaticBuilding();
            pathBuilding.Id = 1;
            pathBuilding.DataType = DataType.Building;
            pathBuilding.BuildingType = StaticBuildingType.Infrastructure;
            pathBuilding.TagName = "building_path";
            pathBuilding.Name = "Path";
            pathBuilding.GoldCost = 100;
            pathBuilding.IsBuilt = false;
            pathBuilding.Maintenance = 10;
            pathBuilding.BuildTime = 2;
            pathBuilding.RemainingBuildTime = pathBuilding.BuildTime;
            pathBuilding.StartBuilding = false;
            

            StaticBuilding roadBuilding = new StaticBuilding();
            roadBuilding.Id = 2;
            roadBuilding.DataType = DataType.Building;
            roadBuilding.BuildingType = StaticBuildingType.Infrastructure;
            roadBuilding.TagName = "building_road";
            roadBuilding.Name = "Road";
            roadBuilding.GoldCost = 100;
            roadBuilding.IsBuilt = false;
            roadBuilding.Maintenance = 10;
            roadBuilding.Prerequisites.Add("building_path");
            roadBuilding.UpgradesFrom = "building_path";
            roadBuilding.BuildTime = 2;
            roadBuilding.RemainingBuildTime = roadBuilding.BuildTime;
            roadBuilding.StartBuilding = false;

            DataCollection.Buildings.DataType = DataType.Building;
            DataCollection.Buildings.Add("building_path", pathBuilding);
            DataCollection.Buildings.Add("building_road", roadBuilding);
        }


        public void SaveData()
        {
            _dataManager.SaveData(Constants.PlayersFileName, DataCollection.Players, Path);
            _dataManager.SaveData(Constants.CountriesFileName, DataCollection.Countries, Path);
            _dataManager.SaveData(Constants.ProvincesFileName, DataCollection.Provinces, Path);
            _dataManager.SaveData(Constants.RegionsFileName, DataCollection.Regions, Path);
            _dataManager.SaveData(Constants.CitysFileName, DataCollection.Citys, Path);
            _dataManager.SaveData(Constants.FarmsFileName, DataCollection.Farms, Path);
            _dataManager.SaveData(Constants.PortsFileName, DataCollection.Ports, Path);
            _dataManager.SaveData(Constants.InfrastructureFileName, DataCollection.Infrastructures, Path);
            _dataManager.SaveData(Constants.IndustryFileName, DataCollection.Industries, Path);
            _dataManager.SaveData(Constants.BuildingsFileName, DataCollection.Buildings, Path);
        }


    }
}