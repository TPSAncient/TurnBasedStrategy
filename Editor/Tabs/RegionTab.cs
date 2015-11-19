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
            Load();
        }

        public void Draw()
        {
            DrawProvinceList();
        }

        public void DrawProvinceList()
        {
            GUILayout.BeginArea(new Rect(10, 45, 500, 100));

            var rect = EditorGUILayout.BeginVertical();

            EditorGUILayout.LabelField("Region List", EditorStyles.boldLabel);

            SelectedItemId = EditorGUILayout.IntPopup("Regions", SelectedItemId, PopupDataList.Select(x => x.Name).ToArray(), PopupDataList.Select(x => x.Id).ToArray());

            EditorGUILayout.EndVertical();

            GUILayout.EndArea();
        }
    }
}