using Core.Data.Actor;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.Data.World.Region.City;
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
            var region = new SeedRegionData();
            
            DataCollection.Regions.DataType = DataType.Region;
            DataCollection.Regions = region.Regions;
        }

        public void SeedCitiesData()
        {
            var city = new SeedCityData();

            DataCollection.Citys.DataType = DataType.City;
            DataCollection.Citys = city.Citys;
        }

        public void SeedFarmsData()
        {
            var farm = new SeedFarmData();
            DataCollection.Farms.DataType = DataType.Farm;
            DataCollection.Farms = farm.Farms;
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