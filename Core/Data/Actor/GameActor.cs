using System.Linq;
using Core.Data.Common;
using Core.Data.World.Country;

namespace Core.Data.Actor
{
    public class GameActor : StaticActor
    {
        public GameCountry Country { get; set; }


        public IData GetData(IData data)
        {
            switch (data.DataType)
            {
                case DataType.City:
                {
                    data = Country.Regions.Values.Single(x => x.City.TagName == data.TagName);
                    return data;
                }

            }
            return data;
        }
    }
}