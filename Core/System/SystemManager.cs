using System.Collections.Generic;
using System.Threading;
using Core.Data.Actor;
using Core.Data.Building;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System.BuildingSystem;

namespace Core.System
{
    /// <summary>
    /// Start class
    /// </summary>
    public class SystemManager : UnityMonoBehaviour
    {
        public TurnManager TurnManager { get; set; }
        public SelectManager SelectManager { get; set; }

        public BuildingManager BuildingManager { get; set; } 

        public SystemManager(TurnManager turnManager, SelectManager selectManager)
        {
            
            TurnManager = new TurnManager();
            SelectManager = new SelectManager(DataCollection);
            BuildingManager = new BuildingManager();
        }

        #region Variables

        public string Path { get; set; }
        public List<StaticActor> Actors { get; set; } 
        #endregion

        public DataCollection DataCollection { get; set; } = new DataCollection();
        
        private DataManager _dataManager { get; set; } = new DataManager();

        public override void Awake()
        {
            Load();
            Merge();

            SelectManager.Collection = DataCollection;
        }

        public override void Update()
        {
            // Run AI

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

        public void StartBuilding(string tag, DataType type)
        {

            // City tag
            IData tempData = SelectManager.SelectedData;
            // Location Tag

            // Building Tag
            IData data = SelectManager.GetData(tag, type);


            SelectManager.SelectedData = tempData;
        }
    }
}
