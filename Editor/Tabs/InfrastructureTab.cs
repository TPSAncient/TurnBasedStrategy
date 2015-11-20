using Core.Data.Common;
using Core.Data.World.Region;

namespace Editor.Tabs
{
    public class InfrastructureTab : AbstractDataTab<StaticInfrastructure>
    {
        public InfrastructureTab()
        {
            FileName = Constants.InfrastructureFileName;
            TabName = "Infrastructure";
            ListName = "Infrastructure List";
            ModelName = "Infrastructure Model";
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