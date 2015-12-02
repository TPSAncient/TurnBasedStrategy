using Core.Data.Common;
using Core.Data.World.Region;
using Core.Data.World.Region.Infrastructure;
using UnityEditor;
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
                DrawInfrastructureFields();
            }
            else if (IsNew)
            {
                DrawCommonFields();
                DrawInfrastructureFields();
            }
        }

        public void DrawInfrastructureFields()
        {
            GUILayout.BeginArea(new Rect(10, 210, 500, 500));

            Rect = EditorGUILayout.BeginVertical();
            for (int index = 0; index < Data.BuildingTag.Count; index++)
            {
                Debug.Log(Data.BuildingTag);
                Data.BuildingTag[index] = EditorGUILayout.TextField("Building", Data.BuildingTag[index]);
            }
            
            EditorGUILayout.EndVertical();

            GUILayout.EndArea();
        }
    }
}