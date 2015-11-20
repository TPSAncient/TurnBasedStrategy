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
        private PortTab _portTab;
        private InfrastructureTab _infrastructureTab;
        private IndustryTab _industryTab;
        private FarmTab _farmTab;
        private CityTab _cityTab;

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
            _portTab = new PortTab();
            _infrastructureTab = new InfrastructureTab();
            _industryTab = new IndustryTab();
            _farmTab = new FarmTab();
            _cityTab = new CityTab();
        }

        void OnGUI()
        {
            DrawTabs();

            if (GUI.Button(new Rect(5, 20, 100, 20), "Refresh All"))
            {
                _countryTab.Load();
                _provinceTab.Load();
                _regionTab.Load();
                _portTab.Load();
                _infrastructureTab.Load();
                _industryTab.Load();
                _farmTab.Load();
                _cityTab.Load();
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
                case TabType.City:
                {
                    _cityTab.Draw();
                    break;
                }
                case TabType.Farm:
                {
                    _farmTab.Draw();
                    break;
                }
                case TabType.Port:
                {
                    _portTab.Draw();
                    break;
                }
                case TabType.Infrastructure:
                {
                    _infrastructureTab.Draw();
                    break;
                }
                case TabType.Industry:
                {
                    _industryTab.Draw();
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
