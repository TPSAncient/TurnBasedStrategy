using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data;
using Core.Data.World;
using Core.Data.World.Location;
using Core.System.Helpers;

namespace Core.System
{
    public class LoadData
    {
        public void LoadCountryData(out Dictionary<string, StaticCountry> country)
        {
            country =  JsonData.LoadJson<Dictionary<string, StaticCountry>>(Constants.CountriesFileName);
        }

        public void LoadProvincesData(out Dictionary<string, StaticProvince> provinces)
        {
            provinces = JsonData.LoadJson<Dictionary<string, StaticProvince>>(Constants.ProvincesFileName);
        }

        public void LoadRegionsData(out Dictionary<string, StaticRegion> regions)
        {
            regions = JsonData.LoadJson<Dictionary<string, StaticRegion>>(Constants.RegionsFileName);
        }

        public void LoadCitysData(out Dictionary<string, StaticCity> citys)
        {
            citys = JsonData.LoadJson<Dictionary<string, StaticCity>>(Constants.CitysFileName);
        }

        public void LoadFarmsData(out Dictionary<string, StaticFarm> farms)
        {
            farms = JsonData.LoadJson<Dictionary<string, StaticFarm>>(Constants.FarmsFileName);
        }

        public void LoadPortsData(out Dictionary<string, StaticPort> ports)
        {
            ports = JsonData.LoadJson<Dictionary<string, StaticPort>>(Constants.PortsFileName);
        }
    }
}
