using Core.Data.Common;
using Core.Data.World.Region.Farm;

namespace Core.Test.Data
{
    public class SeedFarmData
    {
        public StaticDictionary<StaticFarm> Farms;

        public SeedFarmData()
        {
            Farms = new StaticDictionary<StaticFarm>();

            StaticFarm farm;

            farm = AddFarm("Roma Farm", "farm_roma");
            Farms.Add(farm.TagName, farm);

            farm = AddFarm("Velathri Farm", "farm_velathri");
            Farms.Add(farm.TagName, farm);

            farm = AddFarm("Ariminum Farm", "farm_ariminum");
            Farms.Add(farm.TagName, farm);
        }

        private StaticFarm AddFarm(string name, string tagName)
        {
            StaticFarm farm = new StaticFarm();

            farm.Name = name;
            farm.TagName = tagName;
            farm.DataType = DataType.Farm;
            return farm;
        }
    }
}