using System.Collections.Generic;
using Core.Data.Actor;
using Core.Data.Collection;
using Core.Data.Common;
using Core.System.BuildingSystem;
using Core.System.DataSystem;
using Core.System.SelectSystem;
using Core.System.TurnSystem;

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
        public DataManager DataManager { get; set; }

        public SystemManager(TurnManager turnManager, SelectManager selectManager)
        {
            
            TurnManager = new TurnManager();
            SelectManager = new SelectManager(DefaultDataCollection);
            BuildingManager = new BuildingManager();
            DataManager = new DataManager();
        }

        #region Variables

        public string Path { get; set; }
        public List<StaticActor> Actors { get; set; } 
        #endregion

        public DefaultDataCollection DefaultDataCollection { get; set; } = new DefaultDataCollection();
        public GameDataCollection GameDataCollection { get; set; } = new GameDataCollection();
        
        public override void Awake()
        {
            Load();
            Merge();

            SelectManager.Collection = DefaultDataCollection;
        }

        public override void Update()
        {
            // Run AI

        }

        public void Load()
        {

            DefaultDataCollection = DataManager.LoadAllData(Path);
        }

        public void Merge()
        {
            DataManager.MergeAllData(DefaultDataCollection, GameDataCollection);
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
