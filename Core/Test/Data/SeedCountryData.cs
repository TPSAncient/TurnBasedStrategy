using System.Linq;
using Core.Data.Common;
using Core.Data.World.Country;

namespace Core.Test.Data
{
    public class SeedCountryData
    {
        public StaticDictionary<StaticCountry> Countries;

        public SeedCountryData()
        {
            Countries = new StaticDictionary<StaticCountry>();

            StaticCountry country;

            country = AddCountry("Rome", "country_rome");
            country = AddCountryProvinces(country, "province_italia");
            Countries.Add(country.TagName, country);
        }
 
        private StaticCountry AddCountry(string name, string tagName)
        {
            StaticCountry province = new StaticCountry();

            province.Name = name;
            province.TagName = tagName;
            province.DataType = DataType.Country;
            return province;
        }

        private StaticCountry AddCountryProvinces(StaticCountry country, params string[] provinces)
        {
            //country.TagProvinces = provinces.ToList();
            return country;
        } 
    }
}