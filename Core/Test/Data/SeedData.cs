using System.Collections.Generic;
using Core.Data;
using Core.Data.World;
using Core.Data.World.Location;
using Core.System.Helpers;

namespace Core.Test.Data
{
    public class SeedData
    {
        public Dictionary<int, StaticPlayer> Players { get; set; }
        public Dictionary<string, StaticRegion> Regions { get; set; }
        public Dictionary<string, StaticProvince> Provinces { get; set; }
        public Dictionary<string, StaticCity> Citys { get; set; }
        public Dictionary<string, StaticCountry> Countries { get; set; }

        public SeedData()
        {
            SeedPlayerData();
            SeedCountriesData();
            SeedProvincesData();
            SeedRegionsData();
            SeedCitiesData();
        }


        public void SeedPlayerData()
        {
            Players = new Dictionary<int, StaticPlayer>();
            StaticPlayer player = new StaticPlayer { IsPlayer = true };
            Players.Add(1, player);
        }

        public void SeedCountriesData()
        {
            Countries = new Dictionary<string, StaticCountry>();

            StaticCountry country = new StaticCountry();
            country.Id = 1;
            country.Name = "Rome";
            country.TagName = "country_rome";

            Countries.Add(country.TagName, country);
        }

        public void SeedProvincesData()
        {
            Provinces = new Dictionary<string, StaticProvince>();

            StaticProvince province = new StaticProvince
            {
                Id = 1,
                Name = "Italia",
                TagName = "province_italia"
            };

            Provinces.Add(province.TagName, province);
        }

        public void SeedRegionsData()
        {
            Regions = new Dictionary<string, StaticRegion>();

            StaticRegion regionRoma = new StaticRegion();
            regionRoma.Id = 1;
            regionRoma.CityTag = "city_roma";
            regionRoma.ProvinceTag = "province_italia";
            regionRoma.TagName = "region_roma";
            regionRoma.Player = 1;

            StaticRegion regionVelathria = new StaticRegion();
            regionVelathria.Id = 2;
            regionVelathria.CityTag = "city_velathri";
            regionVelathria.ProvinceTag = "province_italia";
            regionVelathria.TagName = "region_velathria";
            regionVelathria.Player = 1;

            StaticRegion regionAriminum = new StaticRegion();
            regionAriminum.Id = 3;
            regionAriminum.CityTag = "city_ariminum";
            regionAriminum.ProvinceTag = "province_italia";
            regionAriminum.TagName = "region_ariminum";
            regionAriminum.Player = 1;

            Regions.Add(regionRoma.TagName, regionRoma);
            Regions.Add(regionVelathria.TagName, regionVelathria);
            Regions.Add(regionAriminum.TagName, regionAriminum);
        }

        public void SeedCitiesData()
        {
            Citys = new Dictionary<string, StaticCity>();

            StaticCity cityRoma = new StaticCity();
            cityRoma.Id = 1;
            cityRoma.Name = "Roma";
            cityRoma.LocationType = LocationType.City;
            cityRoma.TagName = "city_roma";
            Citys.Add(cityRoma.TagName, cityRoma);

            StaticCity cityVelathri = new StaticCity();
            cityVelathri.Id = 2;
            cityVelathri.Name = "Velathri";
            cityVelathri.LocationType = LocationType.City;
            cityVelathri.TagName = "city_velathri";
            Citys.Add(cityVelathri.TagName, cityVelathri);

            StaticCity cityArminum = new StaticCity();
            cityArminum.Id = 2;
            cityArminum.Name = "Ariminum";
            cityArminum.LocationType = LocationType.City;
            cityArminum.TagName = "city_ariminum";
            Citys.Add(cityArminum.TagName, cityArminum);
        }

        public void SaveData()
        {
            JsonData.SaveJson("Regions", Regions);
            JsonData.SaveJson("Players", Players);
            JsonData.SaveJson("Provinces", Provinces);
            JsonData.SaveJson("Citys", Citys);
            JsonData.SaveJson("Countries", Countries);
        }


    }
}