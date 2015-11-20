using Core.Data.Common;
using Core.Data.World.Region;

namespace Editor.Tabs
{
    public class PortTab : AbstractDataTab<StaticPort>
    {
        public PortTab()
        {
            FileName = Constants.PortsFileName;
            TabName = "Port";
            ListName = "Port List";
            ModelName = "Port Model";
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