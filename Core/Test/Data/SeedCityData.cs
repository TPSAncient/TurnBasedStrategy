using Core.Data.Common;
using Core.Data.World.Region.City;

namespace Core.Test.Data
{
    public class SeedCityData
    {
        public StaticDictionary<StaticCity> Citys;
        public SeedCityData()
        {
            Citys = new StaticDictionary<StaticCity>();

            StaticCity city;

            city = AddCity("Roma City", "city_roma");
            Citys.Add(city.TagName, city);

            city = AddCity("Velathri City", "city_velathri");
            Citys.Add(city.TagName, city);

            city = AddCity("Ariminum City", "city_ariminum");
            Citys.Add(city.TagName, city);
        }

        private StaticCity AddCity(string name, string tagName)
        {
            StaticCity city = new StaticCity();

            city.Name = name;
            city.TagName = tagName;
            city.DataType = DataType.City;
            return city;
        }
    }
}