using Client.Data;
using UnityEngine;
using UnityEngine.UI;

namespace Client.UI
{
    public class UIBuild : MonoBehaviour
    {
        public GameManager GameManager;

        void Awake()
        {
            GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        public void BuildBuilding(UIObject obj)
        {
            GameManager.SystemManager.StartBuilding(obj.TagName, obj.DataType);

            Debug.Log("Start Building" + obj.Name);
        }
    }
}
