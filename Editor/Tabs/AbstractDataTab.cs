using System.Collections.Generic;
using Core.Data.Common;
using Core.System.Helpers;
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