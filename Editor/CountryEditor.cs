using System.Collections.Generic;
using System.Linq;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.System.Helpers;
using Editor.Tabs;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class DataEditor : EditorWindow
    {
        private CountryTab _countryTab;
        private ProvinceTab _provinceTab;
        private RegionTab _regionTab;

        private TabType _tabType = TabType.Country;

        [MenuItem("Game/Data")]
        public static void ShowWindow()
        {
            GetWindow<DataEditor>();
        }

        void OnEnable()
        {
            _countryTab = new CountryTab();
            _provinceTab = new ProvinceTab();
            _regionTab = new RegionTab();
        }

        void OnGUI()
        {
            DrawTabs();

            if (GUI.Button(new Rect(5, 20, 100, 20), "Refresh All"))
            {
                _countryTab.Refresh();
                _provinceTab.Refresh();
                _regionTab.Refresh();
            }
            
            switch (_tabType)
            {
                case TabType.Country:
                {
                    _countryTab.Draw();
                    break;
                }
                case TabType.Province:
                {
                    _provinceTab.Draw();
                    break;
                }
                case TabType.Region:
                {
                    _regionTab.Draw();
                    break;
                }
                default:
                {
                    break;
                }
            }
        }

        public void DrawTabs()
        {
            _tabType = (TabType)GUILayout.Toolbar((int)_tabType, new[] { "Country", "Province", "Region" });
        }
        
    }
}
