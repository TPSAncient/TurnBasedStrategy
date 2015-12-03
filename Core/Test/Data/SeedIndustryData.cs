using Core.Data.Common;
using Core.Data.World.Region.Industry;

namespace Core.Test.Data
{
    public class SeedIndustryData
    {
        public StaticDictionary<StaticIndustry> Industrys; 
        public SeedIndustryData()
        {
            Industrys = new StaticDictionary<StaticIndustry>();

            StaticIndustry industry;

            industry = AddIndustry("Roma Industry", "industry_roma");
            Industrys.Add(industry.TagName, industry);

            industry = AddIndustry("Velathri Industry", "industry_velathri");
            Industrys.Add(industry.TagName, industry);

            industry = AddIndustry("Ariminum Industry", "industry_ariminum");
            Industrys.Add(industry.TagName, industry);
        }

        private StaticIndustry AddIndustry(string name, string tagName)
        {
            StaticIndustry industry = new StaticIndustry();
            
            industry.Name = name;
            industry.TagName = tagName;
            industry.DataType = DataType.Industry;
            return industry;
        }


    }
    
}