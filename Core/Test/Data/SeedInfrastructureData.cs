using System.Globalization;
using System.Linq;
using Core.Data.Common;
using Core.Data.World.Region.Industry;
using Core.Data.World.Region.Infrastructure;

namespace Core.Test.Data
{
    public class SeedInfrastructureData
    {
        public StaticDictionary<StaticInfrastructure> Infrastructures;
        public SeedInfrastructureData()
        {
            Infrastructures = new StaticDictionary<StaticInfrastructure>();

            StaticInfrastructure industry;

            industry = AddInfrastructure("Infra Roma", "infrastructure_roma");
            industry = AddInfrastructureBuildings(industry, "building_path", "building_road");
            Infrastructures.Add(industry.TagName, industry);

            industry = AddInfrastructure("Infra Velathri", "infrastructure_velathri");
            industry = AddInfrastructureBuildings(industry, "building_path");
            Infrastructures.Add(industry.TagName, industry);

            industry = AddInfrastructure("Infra Ariminum", "infrastructure_ariminum");
            industry = AddInfrastructureBuildings(industry, "building_path", "building_road");
            Infrastructures.Add(industry.TagName, industry);
        }

        private StaticInfrastructure AddInfrastructure(string name, string tagName)
        {
            StaticInfrastructure industry = new StaticInfrastructure();

            industry.Name = name;
            industry.TagName = tagName;
            industry.DataType = DataType.Industry;
            return industry;
        }

        private StaticInfrastructure AddInfrastructureBuildings(StaticInfrastructure infrastructure, params string[] buildingTagas)
        {
            infrastructure.BuildingTag = buildingTagas.ToList();
            return infrastructure;
        }
    }
}