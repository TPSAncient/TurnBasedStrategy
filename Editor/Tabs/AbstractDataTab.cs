using System.Collections.Generic;
using System.Linq;
using Core.Data.Common;
using Core.System.Helpers;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class AbstractDataTab<T> where T : new()
    {
        public StaticDictionary<T> DataDictionary { get; set; } = new StaticDictionary<T>();
        public List<PopupData> PopupDataList { get; set; } = new List<PopupData>();

        public T Data { get; set; }

        protected int SelectedItemId;
        protected bool IsNew;
        protected bool IsEmpty;

        public string FileName { get; set; }

        public void DrawCommonList()
        {
            GUILayout.BeginArea(new Rect(10, 45, 500, 100));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Country List", EditorStyles.boldLabel);

            SelectedItemId = EditorGUILayout.IntPopup("Countrys", SelectedItemId, PopupDataList.Select(x => x.Name).ToArray(), PopupDataList.Select(x => x.Id).ToArray());

            if (SelectedItemId > 0)
            {
                IsEmpty = false;
                Data = (T)DataDictionary.Data.Values.Cast<IData>().SingleOrDefault(x => x.Id == SelectedItemId);
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

        public void DrawCommonFields()
        {
            GUILayout.BeginArea(new Rect(10, 100, 500, 500));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Country Settings", EditorStyles.boldLabel);

            ((IData)Data).DataType = DataType.Country;
            ((IData)Data).Id = int.Parse(EditorGUILayout.TextField("Id", ((IData)Data).Id.ToString()));
            ((IData)Data).Name = EditorGUILayout.TextField("Name", ((IData)Data).Name);
            ((IData)Data).TagName = EditorGUILayout.TextField("Tag Name", ((IData)Data).TagName);
            ((IData)Data).DataType = (DataType)EditorGUILayout.EnumPopup("Data Type", ((IData)Data).DataType);

            EditorGUILayout.EndVertical();

            if (IsNew)
            {
                if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "Save"))
                {
                    Save(Data);
                }
            }
            else if (!IsEmpty)
            {
                if (GUI.Button(new Rect(rect.x, rect.y + rect.height, 50, 25), "Update"))
                {
                    Save(Data);
                }
            }

            GUILayout.EndArea();
        }

        public void Clear()
        {
            IsNew = false;
            SelectedItemId = 0;
            Data = new T();
        }

        public void New()
        {
            IsNew = true;
            SelectedItemId = -1;
            Data = new T();
        }

        public void Save(T data)
        {
            if (!DataDictionary.Data.ContainsKey(((IData)data).TagName))
            {
                DataDictionary.Add(((IData)data).TagName, data);
                JsonData.SaveJson(Constants.CountriesFileName, DataDictionary, Application.dataPath);

                PopupDataList.Add(new PopupData { Id = ((IData)data).Id, Name = ((IData)data).Name });
                SelectedItemId = ((IData)data).Id;
                IsNew = false;
            }
        }

        public void Load()
        {
            DataDictionary = LoadData.Load<StaticDictionary<T>>(FileName, Application.dataPath);
            PopupDataList.Add(new PopupData { Id = 0, Name = "Empty" });
            
            foreach (var data in DataDictionary.Data)
            {
                PopupDataList.Add(new PopupData { Id = ((IData)data.Value).Id, Name = ((IData)data.Value).Name });
            }
        }
    }
}