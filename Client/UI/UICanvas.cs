using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Client.UI
{
    public class UICanvas : MonoBehaviour
    {
        public GameObject Canvas { get; set; }
        public GameObject EventListener { get; set; }
        public GameManager GameManager { get; set; }
        private const int LayerUI = 5;
        
        void Start()
        {
            GameObject canvas = CreateCanvas(this.transform);

            EventListener = CreateEventSystem(canvas.transform);

            GameObject uiOverViewObject = new GameObject();
            uiOverViewObject = UIOverView.AddUIOverViewCompnent(uiOverViewObject, new GameManager(), canvas);

            GameObject uiCityViewObject = new GameObject();
            uiCityViewObject = UICityView.AddUICityViewCompnent(uiCityViewObject, new GameManager(), canvas);

            GameObject uiTurnViewObject = new GameObject();
            uiTurnViewObject = UITurnView.AddUITurnViewCompnent(uiTurnViewObject, new GameManager(), canvas);
        }

        void Update()
        {
        }

        public static GameObject AddUICreatorCompnent(GameObject objectAddingUICreatorTo, GameManager gameManager)
        {
            objectAddingUICreatorTo.SetActive(false);

            UICanvas uiCreator = objectAddingUICreatorTo.AddComponent<UICanvas>() as UICanvas;
            uiCreator.GameManager = gameManager;
            objectAddingUICreatorTo.SetActive(true);

            return objectAddingUICreatorTo;
        }


        private GameObject CreateCanvas(Transform parent)
        {
            // create the canvas
            GameObject canvasObject = this.gameObject;
            canvasObject.name = "Canvas";
            canvasObject.layer = LayerUI;
            
            RectTransform canvasTrans = canvasObject.AddComponent<RectTransform>();

            Canvas canvas = canvasObject.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.pixelPerfect = true;

            CanvasScaler canvasScal = canvasObject.AddComponent<CanvasScaler>();
            canvasScal.uiScaleMode = CanvasScaler.ScaleMode.ConstantPhysicalSize;
            canvasScal.referenceResolution = new Vector2(800, 600);

            GraphicRaycaster canvasRayc = canvasObject.AddComponent<GraphicRaycaster>();

            canvasObject.transform.SetParent(parent);

            return canvasObject;
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
