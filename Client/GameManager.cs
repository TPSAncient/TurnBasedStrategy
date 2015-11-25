using Client.UI;
using Core.System;
using Core.Test.Data;
using UnityEngine;

namespace Client
{
    public class GameManager : MonoBehaviour
    {
        public GameObject OverViewPanel;
        public GameObject CityBuilding;

        public SystemManager SystemManager { get; set; }
        public SelectManager SelectManager { get; set; }
        public UIManager UIManager { get; set; }

        void Awake()
        {
            // Don't destroy this class when loading new scene
            DontDestroyOnLoad(this);

            SystemManager = new SystemManager();
            SystemManager.Path = Application.dataPath;
            SystemManager.Awake();

            SelectManager = new SelectManager(SystemManager.DataCollection);

            UIManager = new UIManager();
            UIManager.CityBuilding = CityBuilding;
            UIManager.OverViewPanel = OverViewPanel;
        }

        public void LoadGame()
        {
            
        }

        // test
    }
} 
