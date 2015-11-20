using Core.Data.Common;
using Core.Data.World.Region;
using UnityEditor;
using UnityEngine;

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
                DrawCityFields();
                DrawCommonButtons(new Rect(10, 220, 0, 0));
            }
            else if (IsNew)
            {
                DrawCommonFields();
                DrawCityFields();
                DrawCommonButtons(new Rect(10, 220, 0, 0));
            }
        }

        public void DrawCityFields()
        {
            GUILayout.BeginArea(new Rect(10, 210, 500, 500));

            Rect = EditorGUILayout.BeginVertical();
            for (int index = 1; index < Data.BuildingTag.Count; index++)
            {
                Debug.Log(Data.BuildingTag);
                Data.BuildingTag[index] = EditorGUILayout.TextField("Building", Data.BuildingTag[index]);
            }

            //EditorGUILayout.PropertyField(Data.BuildingTag, GUIContent.none);

            EditorGUILayout.EndVertical();

            GUILayout.EndArea();
        }
    }
}