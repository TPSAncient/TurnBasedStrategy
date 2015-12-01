using System.Linq;
using Core.Data.Common;
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

        void Awake()
        {
            GameObject uiCreator = new GameObject();
            uiCreator = UICanvas.AddUICreatorCompnent(uiCreator, new GameManager());
        }

        void Start()
        {
            
        }
        
    }
}