using System.Linq;
using Core.Data.Common;
using Core.Data.World.Province;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class ProvinceTab : AbstractDataTab<StaticProvince>
    {
        public ProvinceTab()
        {
            FileName = Constants.ProvincesFileName;
            TabName = "Province";
            ListName = "Province List";
            ModelName = "Province Model";
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