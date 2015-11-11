using Core.Data;
using Core.Data.Common;

namespace Core.System.Helpers
{
    public static class SelectData
    {
        public static T GetDataById<T>(IDataDictionary<T> list, DataType type, string id)
        {
            T data;
            if (list.Data.TryGetValue(id, out data))
            {
                return data;
            }
            return default(T);
        }
    }
}