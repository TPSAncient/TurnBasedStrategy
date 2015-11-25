using Core.Data.Common;
using UnityEngine;
using UnityEngine.UI;

namespace Client.UI
{
    public class UIManager
    {
        public GameObject OverViewPanel { get; set; }
        public GameObject CityBuilding { get; set; }

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
        
    }
}