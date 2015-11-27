using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Building;
using Core.Data.Common;
using Core.System.Helpers;

namespace Core.System
{
    public class DataManager
    {
        public T Load<T>(string fileName, string path)
        {
            return JsonData.LoadJson<T>(fileName, path);
        }

        public void SaveData<T>(string name, T obj, string path)
        {
            JsonData.SaveJson(name, obj, path);
        }


        public void MergeRegionData(DataCollection collection)
        {
            MergeData.MergeRegionData(collection);
        }

        public void MergeBuildings<T>(IDataDictionary<T> list, IDataDictionary<StaticBuilding> buildings)
        {
            MergeData.MergeBuildings(list, buildings);
        }
    }
}
