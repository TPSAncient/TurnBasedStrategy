using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using Client.Data;
using Client.UI.Helpers;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Region;
using Core.Data.World.Region.City;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Client.UI
{
    public class UICityView : MonoBehaviour
    {

        private const int LayerUI = 5;
        private GameObject _panel;

        public GameManager GameManager;
        public GameObject Canvas;

        public Dictionary<string, GameObject> Texts;
        public Dictionary<string, GameObject> Buildings;
         
        void Awake()
        {
            Texts = new Dictionary<string, GameObject>();
            Buildings = new Dictionary<string, GameObject>();
            CreateCityView(Canvas);
            //string country = GameManager.SystemManager.GameDataCollection.Player.TagCountry;
            //PopulateBuildings("region_roma", country);
            this.gameObject.SetActive(false);
        }

        public static GameObject AddUICityViewCompnent(GameObject objectAddingUICityViewTo, GameManager gameManager,
           GameObject canvas)
        {
            objectAddingUICityViewTo.SetActive(false);

            UICityView uiCityView = objectAddingUICityViewTo.AddComponent<UICityView>() as UICityView;
            uiCityView.GameManager = gameManager;
            uiCityView.Canvas = canvas;
            objectAddingUICityViewTo.SetActive(true);

            return objectAddingUICityViewTo;
        }

        public void ShowUI(IData data)
        {
            var game = (GameData) data;
            PopulateBuildings(game);
        }

        private void PopulateBuildings(GameData data)
        {
            GameCountry country = GameManager.SystemManager.GameDataCollection.Countrys[data.TagCountry];
            GameCity city = country.Regions.Values.Where(x => x.City.TagName == data.TagName).Select(x=>x.City).SingleOrDefault();
            Texts["CityName"].GetComponent<Text>().text = city.Name;

            int count = 1;
            foreach (var value in city.ListOfPotentialBuilding.Values.Where(x=> string.IsNullOrEmpty(x.UpgradesFrom)))
            {

                Buildings.Add(value.TagName, CreateButton(_panel.transform, new Vector2(200, 20), new Vector2(0, -(30 * count)), value.Name,
                    delegate { OnCancel(); }));
                count++;
            }


            //foreach (var value in city.ListOfCompleteBuilding.Values)
            //{
            //    // if Building is built and there is next level show that

                
                
            //    CreateButton(_panel.transform, new Vector2(200, 20), new Vector2(0, -(30 * count)), value.Name,
            //        delegate { OnCancel(); });
            //    count++;
            //}
        }

        private void CreateCityView(GameObject canvas)
        {
            _panel = CreatePanel(canvas.transform, new Vector2(200, 200), new Vector2(0, -200), "OverView");


            // Text Panel Name
            Texts.Add("CityName", CreateText(_panel.transform, new Vector2(0, 0), new Vector2(50, 20), "City View", 14, "CityName"));

            //CreateButton(panel.transform, new Vector2(200, 20), new Vector2(0, -30), "Road", delegate { OnCancel(); });
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
            //GameObject panelObject = new GameObject(objName);

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

        private GameObject CreateButton(Transform parent, Vector2 sizeDelta, Vector2 anchoredPosition, string message, UnityAction eventListner)
        {
            GameObject buttonObject = new GameObject("Button");
            buttonObject.transform.SetParent(parent);

            buttonObject.layer = LayerUI;

            RectTransform trans = buttonObject.AddComponent<RectTransform>();
            trans.SetPivotAndAnchors(new Vector2(0, 1));
            SetSize(trans, sizeDelta);
            trans.anchoredPosition = anchoredPosition;

            CanvasRenderer renderer = buttonObject.AddComponent<CanvasRenderer>();

            Image image = buttonObject.AddComponent<Image>();
            image.color = Color.grey;
            //Texture2D tex = Resources.Load<Texture2D>("Background");
            //image.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height),
            //                                          new Vector2(0.5f, 0.5f));

            Button button = buttonObject.AddComponent<Button>();
            button.interactable = true;
            button.onClick.AddListener(eventListner);

            GameObject textObject = CreateText(buttonObject.transform, new Vector2(0, 0), new Vector2(50, 20), message, 14, "DataType");

            return buttonObject;
        }

        private static void SetSize(RectTransform trans, Vector2 size)
        {
            Vector2 currSize = trans.rect.size;
            Vector2 sizeDiff = size - currSize;
            trans.offsetMin = trans.offsetMin -
                                      new Vector2(sizeDiff.x * trans.pivot.x,
                                          sizeDiff.y * trans.pivot.y);
            trans.offsetMax = trans.offsetMax +
                                      new Vector2(sizeDiff.x * (1.0f - trans.pivot.x),
                                          sizeDiff.y * (1.0f - trans.pivot.y));
        }

        private void OnCancel()
        {
            Debug.Log("Button pressed");
        }

    }
}