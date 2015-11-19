using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Core.Data.Common;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System.Helpers;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class RegionTab
    {
        public StaticDictionary<StaticRegion> Provinces = new StaticDictionary<StaticRegion>();
        public StaticProvince Province = new StaticProvince();

        private List<PopupData> _regionData = new List<PopupData>();
        private int _selectedSize;

        public RegionTab()
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

            EditorGUILayout.LabelField("Region List", EditorStyles.boldLabel);

            _selectedSize = EditorGUILayout.IntPopup("Regions", _selectedSize, _regionData.Select(x => x.Name).ToArray(), _regionData.Select(x => x.Id).ToArray());

            EditorGUILayout.EndVertical();

            GUILayout.EndArea();
        }

        public void Refresh()
        {
            Provinces = LoadData.Load<StaticDictionary<StaticRegion>>(Constants.RegionsFileName, Application.dataPath);
            _regionData.Add(new PopupData { Id = 0, Name = "Empty" });

            foreach (var province in Provinces.Data)
            {
                _regionData.Add(new PopupData { Id = province.Value.Id, Name = province.Value.Name });
            }
        }
    }
}