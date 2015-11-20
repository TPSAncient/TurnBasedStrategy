using Core.Data.Common;
using Core.Data.World.Region;
using UnityEngine;

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