using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

namespace Client.UI
{
    public class UIManager
    {
        
        public void ChangeDataTypeName(string text)
        {
            GameObject.Find("DataType").GetComponent<Text>().text = text;
        }

        public void ChangeDataName(string text)
        {
            GameObject.Find("DataName").GetComponent<Text>().text = text;
        }

    }
}