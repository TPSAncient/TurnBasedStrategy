using System.Collections.Generic;
using System.Linq;
using Core.Data.Common;
using Core.System.DataSystem;
using Core.System.Helpers;
using UnityEditor;
using UnityEngine;

namespace Editor.Tabs
{
    public class AbstractDataTab<T> : ITab where T : new()
    {
        public StaticDictionary<T> DataDictionary { get; set; } = new StaticDictionary<T>();
        public List<PopupData> PopupDataList { get; set; } = new List<PopupData>();

        public T Data { get; set; }

        protected int SelectedItemId;
        protected bool IsNew;
        protected bool IsEmpty;

        public string FileName { get; set; }
        public string ListName { get; set; }
        public string TabName { get; set; }
        public string ModelName { get; set; }

        protected Rect Rect;

        protected DataManager DataManager { get; } = new DataManager();

        public virtual void Draw() { }

        public void DrawCommonList()
        {
            GUILayout.BeginArea(new Rect(10, 45, 500, 100));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField(TabName, EditorStyles.boldLabel);

            SelectedItemId = EditorGUILayout.IntPopup(ListName, SelectedItemId, PopupDataList.Select(x => x.Name).ToArray(), PopupDataList.Select(x => x.Id).ToArray());

            if (SelectedItemId > 0)
            {
                IsEmpty = false;
                string tagName = PopupDataList.Where(x => x.Id == SelectedItemId).Select(x => x.TagName).FirstOrDefault();

                if (!string.IsNullOrEmpty(tagName))
                {
                    Data = (T)DataDictionary.Data.Values.Cast<IData>().SingleOrDefault(x => x.TagName == tagName);
                }
                else
                {
                    Debug.LogError("Tag Name is null or empty");
                }
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

            if (IsNew)
            {
                if (GUI.Button(new Rect(rect.x + 50, rect.y + rect.height, 50, 25), "Save"))
                {
                    Save(Data);
                }
            }
            else if (!IsEmpty)
            {
                if (GUI.Button(new Rect(rect.x + 50, rect.y + rect.height, 50, 25), "Update"))
                {
                    Save(Data);
                }
            }

            EditorGUILayout.EndVertical();
            GUILayout.EndArea();
        }

        public void DrawCommonFields()
        {
            GUILayout.BeginArea(new Rect(10, 120, 500, 500));
            var rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField(ModelName, EditorStyles.boldLabel);

            ((IData)Data).Name = EditorGUILayout.TextField("Name", ((IData)Data).Name);
            ((IData)Data).TagName = EditorGUILayout.TextField("Tag Name", ((IData)Data).TagName);
            ((IData)Data).DataType = (DataType)EditorGUILayout.EnumPopup("Data Type", ((IData)Data).DataType);

            EditorGUILayout.EndVertical();
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
                int maxId = PopupDataList.Select(x => x.Id).Max();
                PopupDataList.Add(new PopupData { Id = maxId, Name = ((IData)data).Name, TagName = ((IData)data).TagName});
                SelectedItemId = maxId;
                IsNew = false;
            }
        }

        public void Load()
        {
            DataDictionary = DataManager.Load<StaticDictionary<T>>(FileName, Application.dataPath);
            if (DataDictionary == null)
            {
                DataDictionary = new StaticDictionary<T>();
            }

            PopupDataList.Add(new PopupData { Id = 0, Name = "Empty", TagName = "empty"});
            int count = 1;
            foreach (var data in DataDictionary.Data)
            {
                PopupDataList.Add(new PopupData { Id = count, Name = ((IData)data.Value).Name, TagName = ((IData)data.Value).TagName});
                count++;
            }
        }
    }
}