using Core.Data.Actor;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.Data.World.Region.City;
using Core.Data.World.Region.Farm;
using Core.System.DataSystem;

namespace Core.Test.Data
{
    public class SeedData
    {
        private readonly DataManager _dataManager;
        public DefaultDataCollection DataCollection { get; set; } = new DefaultDataCollection();
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
            cityRoma.Name = "Roma";
            cityRoma.DataType = DataType.City;
            cityRoma.TagName = "city_roma";
            

            StaticCity cityVelathri = new StaticCity();
            cityVelathri.Name = "Velathri";
            cityVelathri.DataType = DataType.City;
            cityVelathri.TagName = "city_velathri";
            

            StaticCity cityArminum = new StaticCity();
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
            farmRoma.Name = "Roma Farm";
            farmRoma.TagName = "farm_roma";
            farmRoma.DataType = DataType.Farm;

            StaticFarm farmVelathri = new StaticFarm();
            farmVelathri.Name = "Velathri Farm";
            farmVelathri.TagName = "farm_velathri";
            farmVelathri.DataType = DataType.Farm;

            StaticFarm farmAriminum = new StaticFarm();
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
            var port = new SeedPortData();
            
            DataCollection.Ports.DataType = DataType.Port;
            DataCollection.Ports = port.Ports;
        }

        public void SeedInfrastructureData()
        {
            var infrastructure = new SeedInfrastructureData();
            DataCollection.Infrastructures.DataType = DataType.Infrastructure;

            DataCollection.Infrastructures = infrastructure.Infrastructures;
        }

        public void SeedIndustryData()
        {
            var industrys = new SeedIndustryData();

            DataCollection.Industries.DataType = DataType.Industry;
            DataCollection.Industries = industrys.Industrys;
        }

        public void SeedBuildingsData()
        {
            var buildings = new SeedBuildingData();

            DataCollection.Buildings.DataType = DataType.Building;
            DataCollection.Buildings = buildings.Buildings;
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