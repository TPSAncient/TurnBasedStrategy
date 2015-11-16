using System.Collections.Generic;
using System.Linq;
using Core.Data;
using Core.Data.Common;
using Core.Data.World;
using Core.Data.World.Region;

namespace Core.System.Helpers
{
    public static class MergeData
    {
        public static void MergeRegionData(DataCollection collection)
        {
            foreach (var region in collection.Regions.Data)
            {
                if (region.Value.CanBuildPort)
                {
                    region.Value.Port = collection.Ports.Data[region.Value.PortTag];
                }

                region.Value.City = collection.Citys.Data[region.Value.CityTag];

                region.Value.Farm = collection.Farms.Data[region.Value.FarmTag];


                region.Value.Infrastructure = collection.Infrastructures.Data[region.Value.InfrastructureTag];
            }
        }

        public static void MergeInfrastructureData(DataCollection collection)
        {
            foreach (var infrastructure in collection.Infrastructures.Data)
            {
                foreach (var tag in infrastructure.Value.BuildingTag)
                {
                    var building = collection.Buildings.Data[tag];
                    building.IsBuilt = true;
                    infrastructure.Value.Buildings.Data.Add(tag, building);
                }
            }
        }
    }
}
