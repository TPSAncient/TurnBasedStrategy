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
        private int _selectedSize; 

        public ProvinceTab()
        {
            Refresh();
        }

        public void Draw()
        {
            DrawProvinceList();
        }

        public void DrawProvinceList()
        {
            GUILayout.BeginArea(new Rect(10, 45, 500, 100));

            var rect = EditorGUILayout.BeginVertical();

            EditorGUILayout.LabelField("Province List", EditorStyles.boldLabel);

            _selectedSize = EditorGUILayout.IntPopup("Provinces", _selectedSize, _provinceData.Select(x => x.Name).ToArray(), _provinceData.Select(x => x.Id).ToArray());

            EditorGUILayout.EndVertical();

            GUILayout.EndArea();
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