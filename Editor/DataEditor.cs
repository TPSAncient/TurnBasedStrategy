using System;
using System.Collections.Generic;
using System.Linq;
using Editor.Tabs;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class DataEditor : EditorWindow
    {
        private Dictionary<TabType, ITab> _tabs = new Dictionary<TabType, ITab>();

        private TabType _tabType = TabType.Country;

        [MenuItem("Game/Data")]
        public static void ShowWindow()
        {
            GetWindow<DataEditor>();
        }

        void OnEnable()
        {
            _tabs.Add(TabType.Country, new CountryTab());
            _tabs.Add(TabType.Province, new ProvinceTab());
            _tabs.Add(TabType.Region, new RegionTab());
            _tabs.Add(TabType.Port, new PortTab());
            _tabs.Add(TabType.Infrastructure, new InfrastructureTab());
            _tabs.Add(TabType.Industry, new IndustryTab());
            _tabs.Add(TabType.Farm, new FarmTab());
            _tabs.Add(TabType.City, new CityTab());
            _tabs.Add(TabType.Building, new BuildingTab());
        }

        void OnGUI()
        {
            DrawTabs();

            if (GUI.Button(new Rect(5, 20, 100, 20), "Refresh All"))
            {
                foreach (var tab in _tabs.Values)
                {
                    tab.Load();
                }
            }

            _tabs[_tabType].Draw();
        }

        public void DrawTabs()
        {
            _tabType = (TabType)GUILayout.Toolbar((int)_tabType, Enum.GetNames(typeof(TabType)));
        }
        
    }
}
