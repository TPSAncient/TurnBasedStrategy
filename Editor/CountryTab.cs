using System.Collections.Generic;
using System.Linq;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.System.Helpers;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class CountryTab
    {
        public StaticDictionary<StaticCountry> Countrys = new StaticDictionary<StaticCountry>();
        public StaticCountry NewCountry = new StaticCountry();

        private readonly List<PopupData> _countryData = new List<PopupData>();  
        
        private int _selectedSize = 0;
        private bool _isNew = false;

        public CountryTab()
        {
            Countrys = LoadData.Load<StaticDictionary<StaticCountry>>(Constants.CountriesFileName, Application.dataPath);
            _countryData.Add(new PopupData { Id = 0, Name = "Empty"});
            
            foreach (var country in Countrys.Data)
            {
                _countryData.Add(new PopupData { Id = country.Value.Id, Name = country.Value.Name });
            }
        }

        public void DrawCountrtyList()
        {
            GUILayout.BeginArea(new Rect(10, 20, 500, 100));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Country List", EditorStyles.boldLabel);

            _selectedSize = EditorGUILayout.IntPopup("Countrys", _selectedSize, _countryData.Select(x => x.Name).ToArray(), _countryData.Select(x => x.Id).ToArray());

            if (_selectedSize > 0)
            {
                Populate(Countrys.Data.Values.SingleOrDefault(x => x.Id == _selectedSize));
            }
            else if (!_isNew && _selectedSize == 0)
            {
                Clear();
            }

            if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "New"))
            {
                NewCountry = New(NewCountry);
                _selectedSize = 0;
            }

            EditorGUILayout.EndVertical();
            GUILayout.EndArea();
        }

        public void DrawCountry()
        {
            GUILayout.BeginArea(new Rect(10, 100, 500, 500));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Country Settings", EditorStyles.boldLabel);

            NewCountry.DataType = DataType.Country;
            NewCountry.Id = int.Parse(EditorGUILayout.TextField("Id", NewCountry.Id.ToString()));
            NewCountry.Name = EditorGUILayout.TextField("Name", NewCountry.Name);
            NewCountry.TagName = EditorGUILayout.TextField("Tag Name", NewCountry.TagName);
            NewCountry.DataType = (DataType)EditorGUILayout.EnumPopup("Data Type", NewCountry.DataType);
            EditorGUILayout.EndVertical();



            if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "Save"))
            {
                Save(NewCountry);
            }

            GUILayout.EndArea();
        }

        public void Save(StaticCountry country)
        {
            if (!Countrys.Data.ContainsKey(country.TagName))
            {
                Countrys.Add(country.TagName, country);
                _countryData.Add(new PopupData { Id = country.Id, Name = country.Name });
                _selectedSize = country.Id;

                _isNew = false;
            }
        }

        public void Clear()
        {
            _isNew = false;
            _selectedSize = 0;
            NewCountry = new StaticCountry();
        }

        public StaticCountry New(StaticCountry country)
        {
            _isNew = true;
            _selectedSize = 0;
            return new StaticCountry();
        }

        public void Populate(StaticCountry country)
        {
            NewCountry = country;

        }
    }
}