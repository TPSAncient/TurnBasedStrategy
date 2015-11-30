using Core.Data.Common;
using Core.Data.World;
using Core.System.Helpers;

namespace Core.System.SelectSystem
{
    public class SelectManager
    {
        public DataCollection Collection;
        

        public IData SelectedData { get; set; }

        public SelectManager(DataCollection collection)
        {
            Collection = collection;
        }

        public SelectManager()
        {
        }

        public IData GetData(string tag, DataType type)
        {
            switch (type)
            {
                case DataType.City:
                {
                    SelectedData = SelectData.GetDataById(Collection.Citys, tag);
                    return SelectedData;
                }
                case DataType.Terrain:
                {
                    SelectedData = new StaticTerrain { Id = 1, Name = "default", DataType = DataType.Terrain, TagName = "terrain_default"};
                    return SelectedData;;
                }
            }
            return null;
        }
    }
}
