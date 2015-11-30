using System.Linq;
using Core.Data.Common;
using Core.System;
using Core.System.TurnSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Client.UI
{
    public class UIManager : MonoBehaviour
    {
        public GameObject OverViewPanel;
        public GameObject CityBuilding;

        public GameManager GameManager;
        public GameObject TurnView;
        


        void Start()
        {
            GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            if (GameManager != null)
            {
                if (GameManager.SystemManager != null)
                {
                    TurnManager trun = GameManager.SystemManager.TurnManager;
                    if (trun != null)
                    {
                        var list = TurnView.GetComponentsInChildren<Text>();
                        foreach (var text in list.Where(x => x.name == "Count"))
                        {
                            text.text = GameManager.SystemManager.TurnManager.CurrentTurn.ToString();
                        }
                    }
                }
                
            }
            
            
        }

        public void OpenPanel(IData data)
        {
            switch (data.DataType)
            {
                case DataType.City:
                {
                    OpenOverViewPanel(data);
                    OpenCityBuildingView();
                    break;
                }
                case DataType.Terrain:
                {
                    CloseOverViewPanel();
                    CloseCityBuildingView();
                    break;
                }
                default:
                {
                    CloseOverViewPanel();
                    CloseCityBuildingView();
                    break;
                }
            }
        }


        public void OpenOverViewPanel(IData data)
        {
            if (OverViewPanel != null)
            {
                // Open UI Panel
                OverViewPanel.SetActive(true);
                // Populate Data in Panel
                GameObject.Find("DataType").GetComponent<Text>().text = data.DataType.ToString();
                GameObject.Find("DataName").GetComponent<Text>().text = data.Name;
            }
            
        }

        public void CloseOverViewPanel()
        {
            OverViewPanel?.SetActive(false);
        }

        public void OpenCityBuildingView()
        {
            CityBuilding.SetActive(true);
        }

        public void CloseCityBuildingView()
        {
            CityBuilding.SetActive(false);
        }

        public void ClickedEndTurn()
        {
            var list = TurnView.GetComponentsInChildren<Text>();

            foreach (var text in list.Where(x => x.name == "Count"))
            {
                text.text = GameManager.SystemManager.TurnManager.EndTurn().ToString();
            }
        }

        
    }
}