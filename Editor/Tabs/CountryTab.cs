using System.Collections.Generic;
using System.Linq;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.System.Helpers;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class CountryTab
    {
        public StaticDictionary<StaticCountry> Countrys = new StaticDictionary<StaticCountry>();
        public StaticCountry Country = new StaticCountry();

        private readonly List<PopupData> _countryData = new List<PopupData>();  
        
        private int _selectedItemId;
        private bool _isNew;
        private bool _isEmpty;

        public CountryTab()
        {
            Refresh();
        }

        public void Draw()
        {
            DrawCountrtyList();
            if (!_isEmpty)
            {
                DrawCountry(); 
            }else if (_isNew)
            {
                DrawCountry();
            }      
        }

        public void DrawCountrtyList()
        {
            GUILayout.BeginArea(new Rect(10, 45, 500, 100));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Country List", EditorStyles.boldLabel);

            _selectedItemId = EditorGUILayout.IntPopup("Countrys", _selectedItemId, _countryData.Select(x => x.Name).ToArray(), _countryData.Select(x => x.Id).ToArray());

            if (_selectedItemId > 0)
            {
                _isEmpty = false;
                Populate(Countrys.Data.Values.SingleOrDefault(x => x.Id == _selectedItemId));
            }

            if (_selectedItemId == 0)
            {
                _isEmpty = true;
            }

            else if (!_isNew && _selectedItemId == 0)
            {
                Clear();
            }

            if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "New"))
            {
                Country = New(Country);
                _selectedItemId = 0;
            }

            EditorGUILayout.EndVertical();
            GUILayout.EndArea();
        }

        public void DrawCountry()
        {
            GUILayout.BeginArea(new Rect(10, 100, 500, 500));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Country Settings", EditorStyles.boldLabel);

            Country.DataType = DataType.Country;
            Country.Id = int.Parse(EditorGUILayout.TextField("Id", Country.Id.ToString()));
            Country.Name = EditorGUILayout.TextField("Name", Country.Name);
            Country.TagName = EditorGUILayout.TextField("Tag Name", Country.TagName);
            Country.DataType = (DataType)EditorGUILayout.EnumPopup("Data Type", Country.DataType);
            EditorGUILayout.EndVertical();

            if (_isNew)
            {
                if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "Save"))
                {
                    Save(Country);
                }
            }else if (!_isEmpty)
            {
                if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "Update"))
                {
                    Save(Country);
                }
            }
            
            GUILayout.EndArea();
        }

        public void Save(StaticCountry country)
        {
            if (!Countrys.Data.ContainsKey(country.TagName))
            {
                Countrys.Add(country.TagName, country);
                JsonData.SaveJson(Constants.CountriesFileName,Countrys, Application.dataPath);

                _countryData.Add(new PopupData { Id = country.Id, Name = country.Name });
                _selectedItemId = country.Id;
                _isNew = false;
            }
        }

        public void Clear()
        {
            _isNew = false;
            _selectedItemId = 0;
            Country = new StaticCountry();
        }

        public StaticCountry New(StaticCountry country)
        {
            _isNew = true;
            _selectedItemId = -1;
            return new StaticCountry();
        }

        public void Populate(StaticCountry country)
        {
            Country = country;
        }

        public void Refresh()
        {
            Countrys = LoadData.Load<StaticDictionary<StaticCountry>>(Constants.CountriesFileName, Application.dataPath);
            _countryData.Add(new PopupData { Id = 0, Name = "Empty" });

            foreach (var country in Countrys.Data)
            {
                _countryData.Add(new PopupData { Id = country.Value.Id, Name = country.Value.Name });
            }
        }
    }
}