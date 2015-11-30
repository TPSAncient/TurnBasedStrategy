using Core.Data.Actor;
using Core.Data.Building;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System.Helpers;

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

        public DataCollection LoadAllData(string path)
        {
            var data = new DataCollection();

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

        public void MergeAllData(DataCollection dataCollection)
        {
            MergeRegionData(dataCollection);

            MergeBuildings(dataCollection.Infrastructures, dataCollection.Buildings);
            MergeBuildings(dataCollection.Farms, dataCollection.Buildings);
        }

        public void MergeRegionData(DataCollection collection)
        {
            MergeData.MergeRegionData(collection);
        }

        public void MergeBuildings<T>(IDataDictionary<T> list, IDataDictionary<StaticBuilding> buildings)
        {
            MergeData.MergeBuildings(list, buildings);
        }
    }
}
