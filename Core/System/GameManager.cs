using System.Collections.Generic;
using Core.Data;
using Core.Data.World;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System.Helpers;
using Core.Test.Data;

namespace Core.System
{
    /// <summary>
    /// Start class
    /// </summary>
    public class GameManager : UnityMonoBehaviour
    {
        #region Variables

        private IDataDictionary<StaticCountry> _countries;
        private IDataDictionary<StaticPlayer> _players;
        private IDataDictionary<StaticProvince> _provinces;
        private IDataDictionary<StaticCity> _citys;
        private IDataDictionary<StaticFarm> _farms;
        private IDataDictionary<StaticPort> _ports;
        private IDataDictionary<StaticRegion> _regions;

        public IDataDictionary<StaticPlayer> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        public IDataDictionary<StaticCountry> Countries
        {
            get { return _countries; }
            set { _countries = value; }
        }

        public IDataDictionary<StaticProvince> Provinces
        {
            get { return _provinces; }
            set { _provinces = value; }
        }

        public IDataDictionary<StaticRegion> Regions
        {
            get { return _regions; }
            set { _regions = value; }
        }

        public IDataDictionary<StaticCity> Citys
        {
            get { return _citys; }
            set { _citys = value; }
        }

        public IDataDictionary<StaticFarm> Farms
        {
            get { return _farms; }
            set { _farms = value; }
        }

        public IDataDictionary<StaticPort> Ports
        {
            get { return _ports; }
            set { _ports = value; }
        }

        #endregion


        public override void Awake()
        {
            LoadData();
            Merge();
        }

        public void LoadData()
        {
            // For populatind data files with basic data
            SeedData data = new SeedData();
            data.SaveData();

            LoadData load = new LoadData();
            load.LoadPlayersData(out _players);
            load.LoadCountryData(out _countries);
            load.LoadProvincesData(out _provinces);
            load.LoadRegionsData(out _regions);
            load.LoadCitysData(out _citys);
            load.LoadFarmsData(out _farms);
            load.LoadPortsData(out _ports);

            IDataDictionary<StaticCountry> cc = new StaticCountryDictionary();
            cc = _countries;
            StaticCountry c = SelectData.GetDataById(cc, DataType.Country, "country_rome");
            
        }

        public void Merge()
        {
            MergeData.MergeRegionData(Regions, Ports, Citys, Farms);
        }
        
    }
}
