using System.Collections.Generic;
using Core.Data.Actor;
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
            SelectManager = new SelectManager(DataCollection);
            BuildingManager = new BuildingManager();
            DataManager = new DataManager();
        }

        #region Variables

        public string Path { get; set; }
        public List<StaticActor> Actors { get; set; } 
        #endregion

        public DataCollection DataCollection { get; set; } = new DataCollection();
        
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

            DataCollection = DataManager.LoadAllData(Path);
        }

        public void Merge()
        {
            DataManager.MergeAllData(DataCollection);
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
