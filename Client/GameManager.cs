using Client.UI;
using Core.System;
using Core.Test.Data;
using UnityEngine;

namespace Client
{
    public class GameManager : MonoBehaviour
    {
        public GameObject OverViewPanel;

        public SystemManager SystemManager { get; set; }
        public SelectManager SelectManager { get; set; }
        public UIManager UIManager { get; set; }

        void Awake()
        {
            // Don't destroy this class when loading new scene
            DontDestroyOnLoad(this);

            // Game Starting place
            if (false)
            {
                SeedData seedData = new SeedData();
                seedData.Path = Application.dataPath;
                seedData.SaveData();
            }
            

            SystemManager = new SystemManager();
            SystemManager.Path = Application.dataPath;
            SystemManager.Awake();
            SelectManager = new SelectManager(SystemManager.DataCollection);
            UIManager = new UIManager();
            UIManager.OverViewPanel = OverViewPanel;
        }

        public void LoadAllUIGameObjectReferences()
        {
        }

        // test
    }
}
