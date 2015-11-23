using System;
using System.Linq;
using Core.Data.Common;
using Core.Data.World.Region;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class RegionTab : AbstractDataTab<StaticRegion>
    {
        public RegionTab()
        {
            FileName = Constants.RegionsFileName;
            TabName = "Region";
            ListName = "Region List";
            ModelName = "Region Model";
            Load();
        }

        public override void Draw()
        {
            DrawCommonList();
            if (!IsEmpty)
            {
                DrawCommonFields();
                DrawRegionFields();
            }
            else if (IsNew)
            {
                DrawCommonFields();
                DrawRegionFields();
            }
        }

        public void DrawRegionFields()
        {
            GUILayout.BeginArea(new Rect(10, 210, 500, 500));

            Rect = EditorGUILayout.BeginVertical();
            Data.Player = Int32.Parse(EditorGUILayout.TextField("Player", Data.Player.ToString()));
            Data.ProvinceTag = EditorGUILayout.TextField("Province", Data.ProvinceTag);
            Data.CityTag = EditorGUILayout.TextField("City", Data.CityTag);
            Data.FarmTag = EditorGUILayout.TextField("Farm", Data.FarmTag);
            Data.PortTag = EditorGUILayout.TextField("Port", Data.PortTag);
            Data.InfrastructureTag = EditorGUILayout.TextField("Infrastructure", Data.InfrastructureTag);
            Data.IndustryTag = EditorGUILayout.TextField("Industry", Data.IndustryTag);
            

            EditorGUILayout.EndVertical();

            GUILayout.EndArea();
        }
    }
}