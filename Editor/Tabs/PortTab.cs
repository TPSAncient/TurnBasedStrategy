﻿using Core.Data.Common;
using Core.Data.World.Region;
using UnityEngine;

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