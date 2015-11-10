using System.Collections.Generic;
using Core.Data;
using Core.Data.World;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System.Helpers;

namespace Core.Test.Data
{
    public class SeedData
    {
        public IDataDictionary<StaticPlayer> Players { get; set; }
        public IDataDictionary<StaticCountry> Countries { get; set; }
        public IDataDictionary<StaticProvince> Provinces { get; set; }
        public IDataDictionary<StaticRegion> Regions { get; set; }
        public IDataDictionary<StaticCity> Citys { get; set; }
        public IDataDictionary<StaticFarm> Farms { get; set; }
        public IDataDictionary<StaticPort> Ports { get; set; } 

        public SeedData()
        {
            SeedPlayerData();
            SeedCountriesData();
            SeedProvincesData();
            SeedRegionsData();
            SeedCitiesData();
            SeedFarmsData();
            SeedPortsData();
        }

        public void SeedPlayerData()
        {
            Players = new StaticPlayerDictionary();
            StaticPlayer player = new StaticPlayer { IsPlayer = true };
            Players.Add("1", player);
        }

        public void SeedCountriesData()
        {
            Countries = new StaticCountryDictionary();

            StaticCountry country = new StaticCountry();
            country.Id = 1;
            country.Name = "Rome";
            country.TagName = "country_rome";
            country.DataType = DataType.Country;

            Countries.Add(country.TagName, country);
        }

        public void SeedProvincesData()
        {
            Provinces = new StaticProvinceDictionary();

            StaticProvince province = new StaticProvince
            {
                Id = 1,
                Name = "Italia",
                TagName = "province_italia",
                DataType = DataType.Province
            };

            Provinces.Add(province.TagName, province);
        }

        public void SeedRegionsData()
        {
            Regions = new StaticRegionDictionary();

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

            Regions.Add(regionRoma.TagName, regionRoma);
            Regions.Add(regionVelathria.TagName, regionVelathria);
            Regions.Add(regionAriminum.TagName, regionAriminum);
        }

        public void SeedCitiesData()
        {
            Citys = new StaticCityDictionary();

            StaticCity cityRoma = new StaticCity();
            cityRoma.Id = 1;
            cityRoma.Name = "Roma";
            cityRoma.DataType = DataType.City;
            cityRoma.TagName = "city_roma";
            Citys.Add(cityRoma.TagName, cityRoma);

            StaticCity cityVelathri = new StaticCity();
            cityVelathri.Id = 2;
            cityVelathri.Name = "Velathri";
            cityVelathri.DataType = DataType.City;
            cityVelathri.TagName = "city_velathri";
            Citys.Add(cityVelathri.TagName, cityVelathri);

            StaticCity cityArminum = new StaticCity();
            cityArminum.Id = 2;
            cityArminum.Name = "Ariminum";
            cityArminum.DataType = DataType.City;
            cityArminum.TagName = "city_ariminum";
            Citys.Add(cityArminum.TagName, cityArminum);
        }

        public void SeedFarmsData()
        {
            Farms = new StaticFarmDictionary();

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

            Farms.Add("farm_roma", farmRoma);
            Farms.Add("farm_velathri", farmVelathri);
            Farms.Add("farm_ariminum", farmAriminum);
        }

        public void SeedPortsData()
        {
            Ports = new StaticPortDictionary();

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

            Ports.Add("port_roma", portRoma);
            Ports.Add("port_velathri", portRoma);
            Ports.Add("port_ariminum", portRoma);
        }

        public void SaveData()
        {
            JsonData.SaveJson("Players", Players);
            JsonData.SaveJson("Countries", Countries);
            JsonData.SaveJson("Provinces", Provinces);
            JsonData.SaveJson("Regions", Regions);
            JsonData.SaveJson("Citys", Citys);
            JsonData.SaveJson("Farms", Farms);
            JsonData.SaveJson("Ports", Ports);
        }


    }
}