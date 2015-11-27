using Core.Data.Actor;
using Core.Data.Building;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;

namespace Core.System
{
    /// <summary>
    /// Start class
    /// </summary>
    public class SystemManager : UnityMonoBehaviour
    {
        #region Variables

        public string Path { get; set; }

        public IDataDictionary<StaticActor> Players
        {
            get { return DataCollection.Players; }
            set { DataCollection.Players = value; }
        }

        public IDataDictionary<StaticCountry> Countries
        {
            get { return DataCollection.Countries; }
            set { DataCollection.Countries = value; }
        }

        public IDataDictionary<StaticProvince> Provinces
        {
            get { return DataCollection.Provinces; }
            set { DataCollection.Provinces = value; }
        }

        public IDataDictionary<StaticRegion> Regions
        {
            get { return DataCollection.Regions; }
            set { DataCollection.Regions = value; }
        }

        public IDataDictionary<StaticCity> Citys
        {
            get { return DataCollection.Citys; }
            set { DataCollection.Citys = value; }
        }

        public IDataDictionary<StaticFarm> Farms
        {
            get { return DataCollection.Farms; }
            set { DataCollection.Farms = value; }
        }

        public IDataDictionary<StaticPort> Ports
        {
            get { return DataCollection.Ports; }
            set { DataCollection.Ports = value; }
        }

        #endregion

        public DataCollection DataCollection { get; set; } = new DataCollection();
        
        private DataManager _dataManager { get; set; } = new DataManager();

        public override void Awake()
        {
            Load();
            Merge();
        }

        public void Load()
        {

            DataCollection.Players = _dataManager.Load<StaticDictionary<StaticActor>>(Constants.PlayersFileName, Path);
            DataCollection.Countries = _dataManager.Load<StaticDictionary<StaticCountry>>(Constants.CountriesFileName, Path);
            DataCollection.Provinces = _dataManager.Load<StaticDictionary<StaticProvince>>(Constants.ProvincesFileName, Path);
            DataCollection.Regions = _dataManager.Load<StaticDictionary<StaticRegion>>(Constants.RegionsFileName, Path);
            DataCollection.Citys = _dataManager.Load<StaticDictionary<StaticCity>>(Constants.CitysFileName, Path);
            DataCollection.Farms = _dataManager.Load<StaticDictionary<StaticFarm>>(Constants.FarmsFileName, Path);
            DataCollection.Ports= _dataManager.Load<StaticDictionary<StaticPort>>(Constants.PortsFileName, Path);
            DataCollection.Infrastructures= _dataManager.Load<StaticDictionary<StaticInfrastructure>>(Constants.InfrastructureFileName, Path);
            DataCollection.Industries= _dataManager.Load<StaticDictionary<StaticIndustry>>(Constants.IndustryFileName, Path);
            DataCollection.Buildings = _dataManager.Load<StaticDictionary<StaticBuilding>>(Constants.BuildingsFileName, Path);
        }

        public void Merge()
        {
            _dataManager.MergeRegionData(DataCollection);

            _dataManager.MergeBuildings(DataCollection.Infrastructures, DataCollection.Buildings);
            _dataManager.MergeBuildings(DataCollection.Farms, DataCollection.Buildings);
        }
        
    }
}
