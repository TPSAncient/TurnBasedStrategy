using Core.Data.Common;
using Core.Data.World.Region;

namespace Editor.Tabs
{
    public class CityTab : AbstractDataTab<StaticCity>
    {
        public CityTab()
        {
            FileName = Constants.CitysFileName;
            TabName = "City";
            ListName = "City List";
            ModelName = "City Model";
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