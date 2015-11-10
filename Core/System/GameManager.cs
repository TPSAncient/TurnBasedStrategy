using System.Collections.Generic;
using Core.Data;
using Core.Data.World;
using Core.Data.World.Location;
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

        private Dictionary<string, StaticCountry> _countries;
        private Dictionary<int, StaticPlayer> _players;
        private Dictionary<string, StaticProvince> _provinces;
        private Dictionary<string, StaticCity> _citys;
        private Dictionary<string, StaticFarm> _farms;
        private Dictionary<string, StaticPort> _ports;
        private Dictionary<string, StaticRegion> _regions;

        public Dictionary<int, StaticPlayer> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        public Dictionary<string, StaticCountry> Countries
        {
            get { return _countries; }
            set { _countries = value; }
        }

        public Dictionary<string, StaticProvince> Provinces
        {
            get { return _provinces; }
            set { _provinces = value; }
        }

        public Dictionary<string, StaticRegion> Regions
        {
            get { return _regions; }
            set { _regions = value; }
        }

        public Dictionary<string, StaticCity> Citys
        {
            get { return _citys; }
            set { _citys = value; }
        }

        public Dictionary<string, StaticFarm> Farms
        {
            get { return _farms; }
            set { _farms = value; }
        }

        public Dictionary<string, StaticPort> Ports
        {
            get { return _ports; }
            set { _ports = value; }
        }

        #endregion


        public override void Awake()
        {
            LoadData();
            MergeData();
        }

        public void LoadData()
        {
            // For populatind data files with basic data
            //SeedData data = new SeedData();


            LoadData load = new LoadData();
            load.LoadCountryData(out _countries);
            load.LoadProvincesData(out _provinces);
            load.LoadRegionsData(out _regions);
            load.LoadCitysData(out _citys);
            load.LoadFarmsData(out _farms);
            load.LoadPortsData(out _ports);

            
        }

        public void MergeData()
        {
            MergeData mergeData = new MergeData();
            mergeData.MergeRegionData(Regions, Ports, Citys, Farms);
        }
        
    }
}
