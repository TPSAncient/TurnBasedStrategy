using Core.Data.Common;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Client.UI
{
    public class UIManager : MonoBehaviour
    {
        public GameManager GameManager;

        public GameObject UIOverViewGO;
        public UIOverView UIOverView;

        public GameObject UICityViewGO;
        public UICityView UICityView;

        public GameObject UITurnViewGO;

        public GameObject Canvas;

        public IData CurrentData;

        void Awake()
        {
            SetUpBasicUIComponents();
            SetUpViews();            
        }

        public static GameObject AddUIManagerCompnent(GameObject goTo, GameManager gameManager)
        {
            goTo.SetActive(false);

            UIManager uiManager = goTo.AddComponent<UIManager>() as UIManager;
            uiManager.GameManager = gameManager;
            goTo.SetActive(true);

            return goTo;
        }


        public void ShowUI(IData data)
        {
            CurrentData = data;

            // Show City overview
            UIOverViewGO.SetActive(true);
            UIOverView.ShowUI(data);
            // Show city overview
            UICityViewGO.SetActive(true);
            UICityView.ShowUI(data);
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
            UIOverView = UIOverViewGO.GetComponent<UIOverView>();

            UICityViewGO = new GameObject();
            UICityViewGO = UICityView.AddUICityViewCompnent(UICityViewGO, GameManager, Canvas);
            UICityView = UICityViewGO.GetComponent<UICityView>();

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