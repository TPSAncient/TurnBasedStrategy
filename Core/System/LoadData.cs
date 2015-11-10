using Core.Data;
using Core.Data.World;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System.Helpers;

namespace Core.System
{
    public static class LoadData
    {
        public static T Load<T>(string fileName)
        {
            return JsonData.LoadJson<T>(fileName);
        }
    }
}
