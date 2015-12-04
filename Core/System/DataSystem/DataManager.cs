using System.Linq;
using System.Runtime.Remoting.Messaging;
using Core.Data.Actor;
using Core.Data.Building;
using Core.Data.Collection;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.Data.World.Region.City;
using Core.Data.World.Region.Farm;
using Core.Data.World.Region.Industry;
using Core.Data.World.Region.Infrastructure;
using Core.Data.World.Region.Port;
using Core.System.Helpers;
using UnityEngine;

namespace Core.System.DataSystem
{
    public class DataManager
    {
        public T Load<T>(string fileName, string path)
        {
            return JsonData.LoadJson<T>(fileName, path);
        }

        public void SaveData<T>(string name, T obj, string path)
        {
            JsonData.SaveJson(name, obj, path);
        }

        public DefaultDataCollection LoadAllData(string path)
        {
            var data = new DefaultDataCollection();

            data.Players = Load<StaticDictionary<StaticActor>>(Constants.PlayersFileName, path);
            data.Countries = Load<StaticDictionary<StaticCountry>>(Constants.CountriesFileName, path);
            data.Provinces = Load<StaticDictionary<StaticProvince>>(Constants.ProvincesFileName, path);
            data.Regions = Load<StaticDictionary<StaticRegion>>(Constants.RegionsFileName, path);
            data.Citys = Load<StaticDictionary<StaticCity>>(Constants.CitysFileName, path);
            data.Farms = Load<StaticDictionary<StaticFarm>>(Constants.FarmsFileName, path);
            data.Ports = Load<StaticDictionary<StaticPort>>(Constants.PortsFileName, path);
            data.Infrastructures = Load<StaticDictionary<StaticInfrastructure>>(Constants.InfrastructureFileName, path);
            data.Industries = Load<StaticDictionary<StaticIndustry>>(Constants.IndustryFileName, path);
            data.Buildings = Load<StaticDictionary<StaticBuilding>>(Constants.BuildingsFileName, path);

            return data;
        }

        public void MergeAllData(DefaultDataCollection defaultDataCollection, GameDataCollection gameDataCollection)
        {
            // Merge data from default do game

            // Add all buildings do Game Collection
            gameDataCollection.AllBuildings = defaultDataCollection.Buildings;
            gameDataCollection.Countrys = new StaticDictionary<GameCountry>();

            foreach (var country in defaultDataCollection.Countries.Values)
            {
                gameDataCollection.Countrys.Add(country.TagName, new GameCountry(country));
            }

            foreach (var country in gameDataCollection.Countrys.Values)
            {
                country.Regions = new StaticDictionary<GameRegion>();
                foreach (var region in defaultDataCollection.Regions.Values.Where(x => x.CountryTag == country.TagName))
                {
                    var gameRegion = new GameRegion(region);
                    
                    gameRegion.City = new GameCity(defaultDataCollection.Citys[region.CityTag]);
                    MergeBuildings(defaultDataCollection, gameRegion.City);

                    gameRegion.Farm = new GameFarm(defaultDataCollection.Farms[region.FarmTag]);
                    MergeBuildings(defaultDataCollection, gameRegion.Farm);

                    gameRegion.Port = new GamePort(defaultDataCollection.Ports[region.PortTag]);
                    MergeBuildings(defaultDataCollection, gameRegion.Port);

                    gameRegion.Industry = new GameIndustry(defaultDataCollection.Industries[region.IndustryTag]);
                    MergeBuildings(defaultDataCollection, gameRegion.Industry);

                    gameRegion.Infrastructure = new GameInfrastructure(defaultDataCollection.Infrastructures[region.InfrastructureTag]);
                    MergeBuildings(defaultDataCollection, gameRegion.Infrastructure);

                    country.Regions.Add(gameRegion.TagName, gameRegion);
                }

                foreach (var provinceTag in defaultDataCollection.Regions.Values.Select(x => x.ProvinceTag).Distinct())
                {
                    foreach (var province in defaultDataCollection.Provinces.Values.Where(x => x.TagName == provinceTag))
                    {
                        country.Provinces.Add(province.TagName, new GameProvince(province));
                    }
                }
            }

            MergeRegionData(defaultDataCollection);

            MergeBuildings(defaultDataCollection.Infrastructures, defaultDataCollection.Buildings);
            MergeBuildings(defaultDataCollection.Farms, defaultDataCollection.Buildings);
        }

        private void MergeBuildings(DefaultDataCollection collection, IGameBuilding data)
        {
            data.ListOfCompleteBuilding = new StaticDictionary<GameBuilding>();
            if (((IBuilding) data).BuildingTag != null)
            {
                foreach (var building in ((IBuilding)data).BuildingTag)
                {
                    data.ListOfCompleteBuilding.Add(building, new GameBuilding(collection.Buildings.Values.Single(x => x.TagName == building)));
                }
            }

            
        }

        public void MergeRegionData(DefaultDataCollection collection)
        {
            MergeData.MergeRegionData(collection);
        }

        public void MergeBuildings<T>(IDataDictionary<T> list, IDataDictionary<StaticBuilding> buildings)
        {
            MergeData.MergeBuildings(list, buildings);
        }
    }
}
