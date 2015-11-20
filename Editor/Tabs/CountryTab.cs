using System.Linq;
using Core.Data.Common;
using Core.Data.World.Country;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class CountryTab : AbstractDataTab<StaticCountry>
    {
        public CountryTab()
        {
            FileName = Constants.CountriesFileName;
            TabName = "Country";
            ListName = "Country List";
            ModelName = "Country Model";
            Load();
        }

        public void Draw()
        {
            DrawCommonList();
            if (!IsEmpty)
            {
                DrawCommonFields(); 
            }else if (IsNew)
            {
                DrawCommonFields();
            }      
        }
    }
}