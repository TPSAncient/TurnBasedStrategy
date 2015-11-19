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

        private TabType _tabType = TabType.Country;

        [MenuItem("Game/Data")]
        public static void ShowWindow()
        {
            GetWindow<DataEditor>();
        }

        void OnEnable()
        {
            _countryTab = new CountryTab();
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
