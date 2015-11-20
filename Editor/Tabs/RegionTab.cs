using System.Linq;
using Core.Data.Common;
using Core.Data.World.Region;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class RegionTab : AbstractDataTab<StaticRegion>
    {
        public RegionTab()
        {
            FileName = Constants.RegionsFileName;
            TabName = "Region";
            ListName = "Region List";
            ModelName = "Region Model";
            Load();
        }

        public override void Draw()
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