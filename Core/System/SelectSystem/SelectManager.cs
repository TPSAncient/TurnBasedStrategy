using Core.Data.Collection;
using Core.Data.Common;
using Core.Data.World;
using Core.System.Helpers;

namespace Core.System.SelectSystem
{
    public class SelectManager
    {
        public DefaultDataCollection DefaultCollection;
        public GameDataCollection GameCollection;

        public IData SelectedData { get; set; }

        public SelectManager(DefaultDataCollection defaultDataCollection, GameDataCollection gameDataCollection)
        {
            DefaultCollection = defaultDataCollection;
            GameCollection = gameDataCollection;
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
                    SelectedData = SelectData.GetDataById(DefaultCollection.Citys, tag);
                    return SelectedData;
                }
                case DataType.Terrain:
                {
                    SelectedData = new StaticTerrain { Name = "default", DataType = DataType.Terrain, TagName = "terrain_default"};
                    return SelectedData;;
                }
            }
            return null;
        }
    }
}
