using Core.Data.Common;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

namespace Client.UI
{
    public class UIManager
    {
        public GameObject OverViewPanel { get; set; }
        
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
            if (OverViewPanel != null)
            {
                OverViewPanel.SetActive(false);
            }
        }
    }
}