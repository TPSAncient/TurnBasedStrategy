using Core.System;
using Core.System.SelectSystem;
using Core.System.TurnSystem;
using UnityEngine;

namespace Client
{
    /// <summary>
    /// GameManager initializes all data needed for game.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        public GameObject OverViewPanel;
        public GameObject CityBuilding;

        public SystemManager SystemManager { get; set; }
        
        void Awake()
        {
            // Don't destroy this class when loading new scene
            DontDestroyOnLoad(this);

            SystemManager = new SystemManager(new TurnManager(), new SelectManager());
            SystemManager.Path = Application.dataPath;
            SystemManager.Awake();
            
        }

        void Update()
        {
            SystemManager.Update();
        }


        public void SetUpGameSystems()
        {
            // Create UI Manager
                // Inside UI Manager create UI Objects
            
        }

        // test
    }
} 
