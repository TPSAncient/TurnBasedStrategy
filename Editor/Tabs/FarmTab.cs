using Core.Data.Common;
using Core.Data.World.Region;
using UnityEngine;

namespace Editor.Tabs
{
    public class FarmTab : AbstractDataTab<StaticFarm>
    {
        public FarmTab()
        {
            FileName = Constants.FarmsFileName;
            TabName = "Farm";
            ListName = "Farm List";
            ModelName = "Farm Model";
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