﻿using Core.Data.Common;
using Core.Data.World.Region;
using Core.Data.World.Region.Industry;
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
            }
            else if (IsNew)
            {
                DrawCommonFields();
            }
        }
    }
}