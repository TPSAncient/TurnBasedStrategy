﻿using Core.Data.Building;
using Core.Data.Common;
using UnityEditor;
using UnityEngine;

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
                DrwaBuildingFields();

            }
            else if (IsNew)
            {
                DrawCommonFields();
                DrwaBuildingFields();
            }
        }

        public void DrwaBuildingFields()
        {
            GUILayout.BeginArea(new Rect(10, 210, 500, 500));

            Rect = EditorGUILayout.BeginVertical();

            Data.UpgradesFrom = EditorGUILayout.TextField("Upgrades from", Data.UpgradesFrom);
            Data.DefaultGoldCost = int.Parse(EditorGUILayout.TextField("Gold cost", Data.DefaultGoldCost.ToString()));
            Data.DefaultMaintenance = int.Parse(EditorGUILayout.TextField("Maintenance", Data.DefaultMaintenance.ToString()));

            EditorGUILayout.EndVertical();

            GUILayout.EndArea();
        }
    }
}
