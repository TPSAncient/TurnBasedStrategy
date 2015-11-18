using System;
using System.Collections.Generic;
using System.Linq;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.Data.World.Region;
using Core.System.Helpers;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class CountryEditor : EditorWindow
    {
        public StaticDictionary<StaticCountry> Countrys = new StaticDictionary<StaticCountry>();
        public StaticCountry NewCountry = new StaticCountry();
        List<string> names = new List<string> {"Normal", "Double", "Quadruple"};
        List<int> sizes = new List<int> { 1,2,4};
        private int selectedSize = 1;

        [MenuItem("Game/Country")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow<CountryEditor>();
        }

        void OnEnable()
        {
            Countrys = LoadData.Load<StaticDictionary<StaticCountry>>(Constants.CountriesFileName, Application.dataPath);
        }

        void OnGUI()
        {
            EditorGUILayout.BeginVertical();

            selectedSize = EditorGUILayout.IntPopup("Countrys", selectedSize, Countrys.Data.Values.OrderBy(x => x.Id).Select(p => p.Name).ToArray(), Countrys.Data.Values.OrderBy(x => x.Id).Select(p => p.Id).ToArray());

            EditorGUILayout.EndVertical();

            var rect = EditorGUILayout.BeginVertical();
            GUILayout.Label("Country Settings", EditorStyles.boldLabel);
            NewCountry.Id = int.Parse(EditorGUILayout.TextField("Id", NewCountry.Id.ToString()));
            NewCountry.Name = EditorGUILayout.TextField("Name", NewCountry.Name);
            NewCountry.TagName = EditorGUILayout.TextField("Tag Name", NewCountry.TagName);
            NewCountry.DataType = (DataType) EditorGUILayout.EnumPopup("Data Type", NewCountry.DataType);
            EditorGUILayout.EndVertical();
            
            if (GUI.Button(new Rect(rect.x, rect.y + rect.height , 50, 25), "Save"))
            {
                Debug.Log(rect);    
            }
        }
    }
}
