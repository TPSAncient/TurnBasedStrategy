using Client.UI.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace Client.UI
{
    public class UITurnView : MonoBehaviour
    {
        private const int LayerUI = 5;
        public GameManager GameManager;
        public GameObject Canvas;

        void Awake()
        {
            CreateTurnView(Canvas);
        }

        public static GameObject AddUITurnViewCompnent(GameObject objectAddingUITrunViewTo, GameManager gameManager,
            GameObject canvas)
        {
            objectAddingUITrunViewTo.SetActive(false);

            UITurnView uiOverView = objectAddingUITrunViewTo.AddComponent<UITurnView>() as UITurnView;
            uiOverView.GameManager = gameManager;
            uiOverView.Canvas = canvas;
            objectAddingUITrunViewTo.SetActive(true);

            return objectAddingUITrunViewTo;
        }


        private void CreateTurnView(GameObject canvas)
        {
            GameObject panel = CreatePanel(canvas.transform, new Vector2(200, 50), new Vector2(0, 0), "TurnView");

        }

        private GameObject CreatePanel(Transform parent, Vector2 sizeDelta, Vector2 anchoredPosition, string objName)
        {
            GameObject panelObject = this.gameObject;  //new GameObject(objName);
            panelObject.name = objName;
            panelObject.transform.SetParent(parent);

            panelObject.layer = LayerUI;

            RectTransform trans = panelObject.AddComponent<RectTransform>();

            trans.SetPivotAndAnchors(new Vector2(1, 0));
            trans.anchoredPosition = anchoredPosition;
            trans.sizeDelta = sizeDelta;

            CanvasRenderer renderer = panelObject.AddComponent<CanvasRenderer>();

            Image image = panelObject.AddComponent<Image>();
            //Texture2D tex = Resources.Load<Texture2D>("panel_bkg");
            //image.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height),
            //                                          new Vector2(0.5f, 0.5f));

            return panelObject;
        }
    }
}