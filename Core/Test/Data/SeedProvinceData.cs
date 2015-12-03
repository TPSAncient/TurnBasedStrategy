using Core.Data.Common;
using Core.Data.World.Province;

namespace Core.Test.Data
{
    public class SeedProvinceData
    {
        public StaticDictionary<StaticProvince> Provinces; 
        public SeedProvinceData()
        {
            Provinces = new StaticDictionary<StaticProvince>();

            StaticProvince province;

            province = AddProvince("Italia", "province_italia");
            Provinces.Add(province.TagName, province);
        }

        private StaticProvince AddProvince(string name, string tagName)
        {
            StaticProvince province = new StaticProvince();

            province.Name = name;
            province.TagName = tagName;
            province.DataType = DataType.Province;
            return province;
        }
    }
}