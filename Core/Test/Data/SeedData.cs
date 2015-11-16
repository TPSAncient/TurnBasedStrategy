using Core.Data.Actor;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System.Helpers;

namespace Core.Test.Data
{
    public class SeedData
    {
        public DataCollection DataCollection { get; set; } = new DataCollection();

        public SeedData()
        {
            SeedPlayerData();
            SeedCountriesData();
            SeedProvincesData();
            SeedRegionsData();
            SeedCitiesData();
            SeedFarmsData();
            SeedPortsData();
            SeedInfrastructureData();
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
            regionRoma.CityTag = "city_roma";
            regionRoma.FarmTag = "farm_roma";
            regionRoma.PortTag = "port_roma";
            regionRoma.CanBuildPort = true;
            regionRoma.ProvinceTag = "province_italia";
            regionRoma.TagName = "region_roma";
            regionRoma.Player = 1;
            regionRoma.DataType = DataType.Region;

            StaticRegion regionVelathria = new StaticRegion();
            regionVelathria.Id = 2;
            regionVelathria.CityTag = "city_velathri";
            regionVelathria.FarmTag = "farm_velathri";
            regionVelathria.PortTag = "port_velathri";
            regionVelathria.CanBuildPort = true;
            regionVelathria.ProvinceTag = "province_italia";
            regionVelathria.TagName = "region_velathria";
            regionVelathria.Player = 1;
            regionVelathria.DataType = DataType.Region;

            StaticRegion regionAriminum = new StaticRegion();
            regionAriminum.Id = 3;
            regionAriminum.CityTag = "city_ariminum";
            regionAriminum.FarmTag = "farm_ariminum";
            regionAriminum.PortTag = "port_ariminum";
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
            cityArminum.Id = 2;
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
            StaticInfrastructure infrastructureRoma = new StaticInfrastructure
            {
                Id = 1,
                Name = "Infra Roma",
                DataType = DataType.Infrastructure,
                TagName = "infrastructure_roma"
            };

            StaticInfrastructure infrastructureVelathri = new StaticInfrastructure
            {
                Id = 1,
                Name = "Infra Velathri",
                DataType = DataType.Infrastructure,
                TagName = "infrastructure_velathri"
            };

            StaticInfrastructure infrastructureAriminum = new StaticInfrastructure
            {
                Id = 1,
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
            
        }

        public void SaveData()
        {
            JsonData.SaveJson(Constants.PlayersFileName, DataCollection.Players);
            JsonData.SaveJson(Constants.CountriesFileName, DataCollection.Countries);
            JsonData.SaveJson(Constants.ProvincesFileName, DataCollection.Provinces);
            JsonData.SaveJson(Constants.RegionsFileName, DataCollection.Regions);
            JsonData.SaveJson(Constants.CitysFileName, DataCollection.Citys);
            JsonData.SaveJson(Constants.FarmsFileName, DataCollection.Farms);
            JsonData.SaveJson(Constants.PortsFileName, DataCollection.Ports);
            JsonData.SaveJson(Constants.InfrastructureFileName, DataCollection.Infrastructures);
        }


    }
}