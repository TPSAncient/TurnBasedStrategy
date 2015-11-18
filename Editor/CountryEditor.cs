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

        public List<string> Names = new List<string>();
        public List<int> IDs = new List<int>();  
        private int selectedSize = 0;

        [MenuItem("Game/Country")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow<CountryEditor>();
        }

        void OnEnable()
        {
            Countrys = LoadData.Load<StaticDictionary<StaticCountry>>(Constants.CountriesFileName, Application.dataPath);
            Names.Add("Empty");
            IDs.Add(0);
            Names.AddRange(Countrys.Data.Values.OrderBy(x => x.Id).Select(p => p.Name).ToList());
            IDs.AddRange(Countrys.Data.Values.OrderBy(x => x.Id).Select(p => p.Id).ToList());
        }

        void OnGUI()
        {
            EditorGUILayout.BeginVertical();

            selectedSize = EditorGUILayout.IntPopup("Countrys", selectedSize, Names.ToArray(), IDs.ToArray());

            if (selectedSize > 0)
            {
                Populate(Countrys.Data.Values.SingleOrDefault(x => x.Id == selectedSize));
            }
            
            EditorGUILayout.EndVertical();

            var rect = EditorGUILayout.BeginVertical();
            GUILayout.Label("Country Settings", EditorStyles.boldLabel);

            NewCountry.DataType = DataType.Country;
            NewCountry.Id = int.Parse(EditorGUILayout.TextField("Id", NewCountry.Id.ToString()));
            NewCountry.Name = EditorGUILayout.TextField("Name", NewCountry.Name);
            NewCountry.TagName = EditorGUILayout.TextField("Tag Name", NewCountry.TagName);
            NewCountry.DataType = (DataType) EditorGUILayout.EnumPopup("Data Type", NewCountry.DataType);
            EditorGUILayout.EndVertical();
            
            if (GUI.Button(new Rect(rect.x, rect.y + rect.height , 50, 25), "New"))
            {
                NewCountry = New(NewCountry);
                selectedSize = 0;
            }

            if (GUI.Button(new Rect(rect.x+50, rect.y + rect.height, 50, 25), "Save"))
            {
                Save(NewCountry);
            }
        }

        public void Save(StaticCountry country)
        {
            if (!Countrys.Data.ContainsKey(country.TagName))
            {
                Countrys.Add(country.TagName, country);
                Names.Add(country.Name);
                IDs.Add(country.Id);
                selectedSize = country.Id;
            }
        }

        public StaticCountry New(StaticCountry country)
        {
            return new StaticCountry();
        }

        public void Populate(StaticCountry country)
        {
            NewCountry = country;
        }
    }
}
