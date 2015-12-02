using UnityEngine;
using UnityEngine.EventSystems;

namespace Client.UI
{
    public class UIManager : MonoBehaviour
    {
        public GameManager GameManager;
        public GameObject UIOverViewGO;
        public GameObject UICityViewGO;
        public GameObject UITurnViewGO;

        public GameObject Canvas;

        void Awake()
        {
            GetGameManager();
            SetUpBasicUIComponents();
            SetUpViews();            
        }

        void Start()
        {
            
        }

        private void GetGameManager()
        {
            GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        private void SetUpBasicUIComponents()
        {
            Canvas = new GameObject();
            Canvas = UICanvas.AddUICreatorCompnent(Canvas, GameManager);

            CreateEventSystem(Canvas.transform);
        }

        private void SetUpViews()
        {
            UIOverViewGO = new GameObject();
            UIOverViewGO = UIOverView.AddUIOverViewCompnent(UIOverViewGO, GameManager, Canvas);

            UICityViewGO = new GameObject();
            UICityViewGO = UICityView.AddUICityViewCompnent(UICityViewGO, GameManager, Canvas);

            UITurnViewGO = new GameObject();
            UITurnViewGO = UITurnView.AddUITurnViewCompnent(UITurnViewGO, GameManager, Canvas);
        }

        private GameObject CreateEventSystem(Transform parent)
        {
            GameObject esObject = new GameObject("EventSystem");

            EventSystem esClass = esObject.AddComponent<EventSystem>();
            esClass.sendNavigationEvents = true;
            esClass.pixelDragThreshold = 5;

            StandaloneInputModule stdInput = esObject.AddComponent<StandaloneInputModule>();
            stdInput.horizontalAxis = "Horizontal";
            stdInput.verticalAxis = "Vertical";

            TouchInputModule touchInput = esObject.AddComponent<TouchInputModule>();

            esObject.transform.SetParent(parent);

            return esObject;
        }
    }
}