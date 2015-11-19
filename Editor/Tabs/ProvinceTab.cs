using System.Collections.Generic;
using System.Linq;
using Core.Data.Common;
using Core.Data.World.Province;
using Core.System.Helpers;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class ProvinceTab
    {
        public StaticDictionary<StaticProvince> Provinces = new StaticDictionary<StaticProvince>();
        public StaticProvince Province = new StaticProvince();

        private List<PopupData> _provinceData = new List<PopupData>();
        private int _selectedItemId;
        private bool _isNew;
        private bool _isEmpty;

        public ProvinceTab()
        {
            Refresh();
        }

        public void Draw()
        {
            DrawProvinceList();
            DrawProvince();
        }

        public void DrawProvinceList()
        {
            GUILayout.BeginArea(new Rect(10, 45, 500, 100));

            var rect = EditorGUILayout.BeginVertical();

            EditorGUILayout.LabelField("Province List", EditorStyles.boldLabel);

            _selectedItemId = EditorGUILayout.IntPopup("Provinces", _selectedItemId, _provinceData.Select(x => x.Name).ToArray(), _provinceData.Select(x => x.Id).ToArray());

            if (_selectedItemId > 0)
            {
                _isEmpty = false;
                Populate(Provinces.Data.Values.SingleOrDefault(x => x.Id == _selectedItemId));
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
                Province = New(Province);
                _selectedItemId = 0;
            }

            EditorGUILayout.EndVertical();



            GUILayout.EndArea();
        }

        public void DrawProvince()
        {
            GUILayout.BeginArea(new Rect(10, 100, 500, 500));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Country Settings", EditorStyles.boldLabel);

            Province.DataType = DataType.Country;
            Province.Id = int.Parse(EditorGUILayout.TextField("Id", Province.Id.ToString()));
            Province.Name = EditorGUILayout.TextField("Name", Province.Name);
            Province.TagName = EditorGUILayout.TextField("Tag Name", Province.TagName);
            Province.DataType = (DataType)EditorGUILayout.EnumPopup("Data Type", Province.DataType);

            EditorGUILayout.EndVertical();

            if (_isNew)
            {
                if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "Save"))
                {
                    Save(Province);
                }
            }
            else if (!_isEmpty)
            {
                if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "Update"))
                {
                    Save(Province);
                }
            }

            GUILayout.EndArea();
        }

        public void Save(StaticProvince province)
        {
            if (!Provinces.Data.ContainsKey(province.TagName))
            {
                Provinces.Add(province.TagName, province);
                JsonData.SaveJson(Constants.CountriesFileName, Provinces, Application.dataPath);

                _provinceData.Add(new PopupData { Id = province.Id, Name = province.Name });
                _selectedItemId = province.Id;
                _isNew = false;
            }
        }

        public void Clear()
        {
            _isNew = false;
            _selectedItemId = 0;
            Province = new StaticProvince();
        }

        public void Populate(StaticProvince province)
        {
            Province = province;
        }

        public StaticProvince New(StaticProvince province)
        {
            _isNew = true;
            _selectedItemId = -1;
            return new StaticProvince();
        }

        public void Refresh()
        {
            Provinces = LoadData.Load<StaticDictionary<StaticProvince>>(Constants.ProvincesFileName, Application.dataPath);
            _provinceData.Add(new PopupData { Id = 0, Name = "Empty" });

            foreach (var province in Provinces.Data)
            {
                _provinceData.Add(new PopupData { Id = province.Value.Id, Name = province.Value.Name });
            }
        }

    }
}