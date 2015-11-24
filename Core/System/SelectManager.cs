using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Common;
using Core.Data.World;
using Core.System.Helpers;

namespace Core.System
{
    public class SelectManager
    {
        private readonly DataCollection _collection;

        public IData SelectedData { get; set; }

        public SelectManager(DataCollection collection)
        {
            _collection = collection;
        }

        public void SingleSelect(string tag, DataType type)
        {
            
        }


        public IData GetData(string tag, DataType type)
        {
            switch (type)
            {
                case DataType.City:
                {
                    return SelectData.GetDataById(_collection.Citys, tag);
                }
                case DataType.Terrain:
                {
                    return new StaticTerrain { Id = 1, Name = "default", DataType = DataType.Terrain, TagName = "terrain_default"};
                }
            }
            return null;
        }
    }
}
