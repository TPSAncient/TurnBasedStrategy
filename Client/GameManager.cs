using Client.UI;
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
        public UIManager UIManager;
        public SelectionManager SelectionManager;
        public SystemManager SystemManager { get; set; }
        
        void Awake()
        {
            // Don't destroy this class when loading new scene
            DontDestroyOnLoad(this);

            SystemManager = new SystemManager(new TurnManager(), new SelectManager());
            SystemManager.Path = Application.dataPath;
            SystemManager.Awake();
            SetUpGameSystems();

        }

        void Update()
        {
            SystemManager.Update();
        }


        public void SetUpGameSystems()
        {
            // Create UI Manager
            GameObject selectionManager = new GameObject("SelectionManager");
            SelectionManager = SelectionManager.AddSelectionManagerCompnent(selectionManager, this).GetComponent<SelectionManager>();
            // Inside UI Manager create UI Objects
            GameObject uiManager = new GameObject("UIManager");
            UIManager = UIManager.AddUIManagerCompnent(uiManager, this).GetComponent<UIManager>();
        }

        // test
    }
} 
