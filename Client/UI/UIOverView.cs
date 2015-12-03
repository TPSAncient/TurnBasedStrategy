using Client.UI.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace Client.UI
{
    public class UIOverView : MonoBehaviour
    {
        private const int LayerUI = 5;
        public GameManager GameManager;
        public GameObject Canvas;

        void Awake()
        {
            CreateOverView(Canvas);
        }

        public static GameObject AddUIOverViewCompnent(GameObject objectAddingUIOverViewTo, GameManager gameManager,
            GameObject canvas)
        {
            objectAddingUIOverViewTo.SetActive(false);

            UIOverView uiOverView = objectAddingUIOverViewTo.AddComponent<UIOverView>() as UIOverView;
            uiOverView.GameManager = gameManager;
            uiOverView.Canvas = canvas;
            objectAddingUIOverViewTo.SetActive(true);

            return objectAddingUIOverViewTo;
        }

        private void CreateOverView(GameObject canvas)
        {
            GameObject panel = CreatePanel(canvas.transform, new Vector2(200, 100), new Vector2(0, 0), "OverView");
            
            // Text Panel Name
            CreateText(panel.transform, new Vector2(0, 0), new Vector2(50, 20), "Over View", 14, "PanelName");
            CreateText(panel.transform, new Vector2(60, 0), new Vector2(50, 20), "TempName", 14, "DataName");
            CreateText(panel.transform, new Vector2(0, -30), new Vector2(50, 20), "TempName", 14, "DataType");
        }

        private GameObject CreateText(Transform parent, Vector2 anchoredPosition, Vector2 sizeDelta, string message, int fontSize, string gameObjectName)
        {
            GameObject textObject = new GameObject(gameObjectName);
            textObject.transform.SetParent(parent);

            textObject.layer = LayerUI;

            RectTransform trans = textObject.AddComponent<RectTransform>();

            trans.SetPivotAndAnchors(new Vector2(0, 1));
            trans.sizeDelta = sizeDelta;
            trans.anchoredPosition = anchoredPosition;

            CanvasRenderer renderer = textObject.AddComponent<CanvasRenderer>();

            Text text = textObject.AddComponent<Text>();
            text.supportRichText = true;
            text.text = message;
            text.fontSize = fontSize;
            text.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
            text.alignment = TextAnchor.UpperLeft;
            text.horizontalOverflow = HorizontalWrapMode.Overflow;
            text.color = new Color(0, 0, 1);

            return textObject;
        }

        private GameObject CreatePanel(Transform parent, Vector2 sizeDelta, Vector2 anchoredPosition, string objName)
        {
            GameObject panelObject = this.gameObject;  //new GameObject(objName);
            panelObject.name = objName;
            panelObject.transform.SetParent(parent);

            panelObject.layer = LayerUI;

            RectTransform trans = panelObject.AddComponent<RectTransform>();

            trans.SetPivotAndAnchors(new Vector2(0, 1));
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