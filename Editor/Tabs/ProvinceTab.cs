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
            Load();
        }

        public void Draw()
        {
            DrawCommonList();
            if (!IsEmpty)
            {
                DrawCommonFields();
            }
            else if (IsNew)
            {
                DrawCommonFields();
            }
        }
    }
}