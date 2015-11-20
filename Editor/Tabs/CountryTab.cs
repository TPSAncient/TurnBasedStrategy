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

        public override void Draw()
        {
            DrawCommonList();
            if (!IsEmpty)
            {
                DrawCommonFields();
                DrawCommonButtons(new Rect(10, 220, 0, 0));
            }
            else if (IsNew)
            {
                DrawCommonFields();
                DrawCommonButtons(new Rect(10, 220, 0, 0));
            }      
        }
    }
}