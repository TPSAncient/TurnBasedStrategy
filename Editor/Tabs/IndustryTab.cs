using Core.Data.Common;
using Core.Data.World.Region;
using UnityEngine;

namespace Editor.Tabs
{
    public class IndustryTab : AbstractDataTab<StaticIndustry>
    {
        public IndustryTab()
        {
            FileName = Constants.IndustryFileName;
            TabName = "Industry";
            ListName = "Industry List";
            ModelName = "Industry Model";
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