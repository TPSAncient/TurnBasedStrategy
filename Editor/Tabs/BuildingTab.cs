using Core.Data.Building;
using Core.Data.Common;

namespace Editor.Tabs
{
    public class BuildingTab : AbstractDataTab<StaticBuilding>
    {
        public BuildingTab()
        {
            FileName = Constants.BuildingsFileName;
            TabName = "Building";
            ListName = "Building List";
            ModelName = "Building Model";
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
