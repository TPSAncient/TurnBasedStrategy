using System.Collections.Generic;
using System.Linq;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.System.Helpers;
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

            switch (_tabType)
            {
                case TabType.Country:
                {
                    _countryTab.DrawCountrtyList();
                    _countryTab.DrawCountry();
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
