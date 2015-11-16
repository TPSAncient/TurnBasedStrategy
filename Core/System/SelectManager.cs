using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Common;
using Core.System.Helpers;

namespace Core.System
{
    public class SelectManager
    {
        private readonly DataCollection _collection;

        public SelectManager(DataCollection collection)
        {
            _collection = collection;
        }

        public IData GetData(string tag, DataType type)
        {
            switch (type)
            {
                case DataType.City:
                {
                    return SelectData.GetDataById(_collection.Citys, tag);
                }
            }
            return null;
        }
    }
}
