using System.Linq;
using Core.Data.Common;
using Core.Data.World.Country;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class CountryTab : AbstractDataTab<StaticCountry>
    {
        public CountryTab()
        {
            FileName = Constants.CountriesFileName;
            Load();
        }

        public void Draw()
        {
            DrawCountrtyList();
            if (!IsEmpty)
            {
                DrawCountry(); 
            }else if (IsNew)
            {
                DrawCountry();
            }      
        }

        public void DrawCountrtyList()
        {
            GUILayout.BeginArea(new Rect(10, 45, 500, 100));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Country List", EditorStyles.boldLabel);

            SelectedItemId = EditorGUILayout.IntPopup("Countrys", SelectedItemId, PopupDataList.Select(x => x.Name).ToArray(), PopupDataList.Select(x => x.Id).ToArray());

            if (SelectedItemId > 0)
            {
                IsEmpty = false;
                Data = DataDictionary.Data.Values.SingleOrDefault(x => x.Id == SelectedItemId);
            }

            if (SelectedItemId == 0)
            {
                IsEmpty = true;
            }

            else if (!IsNew && SelectedItemId == 0)
            {
                Clear();
            }

            if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "New"))
            {
                New();
                SelectedItemId = 0;
            }

            EditorGUILayout.EndVertical();
            GUILayout.EndArea();
        }

        public void DrawCountry()
        {
            GUILayout.BeginArea(new Rect(10, 100, 500, 500));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Country Settings", EditorStyles.boldLabel);

            Data.DataType = DataType.Country;
            Data.Id = int.Parse(EditorGUILayout.TextField("Id", Data.Id.ToString()));
            Data.Name = EditorGUILayout.TextField("Name", Data.Name);
            Data.TagName = EditorGUILayout.TextField("Tag Name", Data.TagName);
            Data.DataType = (DataType)EditorGUILayout.EnumPopup("Data Type", Data.DataType);
            EditorGUILayout.EndVertical();

            if (IsNew)
            {
                if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "Save"))
                {
                    Save(Data);
                }
            }else if (!IsEmpty)
            {
                if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "Update"))
                {
                    Save(Data);
                }
            }
            
            GUILayout.EndArea();
        }
    }
}