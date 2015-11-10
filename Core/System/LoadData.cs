using Core.Data;
using Core.Data.World;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System.Helpers;

namespace Core.System
{
    public class LoadData
    {
        public void LoadPlayersData(out IDataDictionary<StaticPlayer> players)
        {
            players = JsonData.LoadJson<StaticPlayerDictionary>(Constants.PlayersFileName);
        }

        public void LoadCountryData(out IDataDictionary<StaticCountry> country)
        {
            country =  JsonData.LoadJson<StaticCountryDictionary>(Constants.CountriesFileName);
        }

        public void LoadProvincesData(out IDataDictionary<StaticProvince> provinces)
        {
            provinces = JsonData.LoadJson<StaticProvinceDictionary>(Constants.ProvincesFileName);
        }

        public void LoadRegionsData(out IDataDictionary<StaticRegion> regions)
        {
            regions = JsonData.LoadJson<StaticRegionDictionary>(Constants.RegionsFileName);
        }

        public void LoadCitysData(out IDataDictionary<StaticCity> citys)
        {
            citys = JsonData.LoadJson<StaticCityDictionary>(Constants.CitysFileName);
        }

        public void LoadFarmsData(out IDataDictionary<StaticFarm> farms)
        {
            farms = JsonData.LoadJson<StaticFarmDictionary>(Constants.FarmsFileName);
        }

        public void LoadPortsData(out IDataDictionary<StaticPort> ports)
        {
            ports = JsonData.LoadJson<StaticPortDictionary>(Constants.PortsFileName);
        }
    }
}
