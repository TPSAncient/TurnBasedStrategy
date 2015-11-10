using System.Collections.Generic;
using Core.Data;
using Core.Data.World;
using Core.Data.World.Location;

namespace Core.System.Helpers
{
    public static class MergeData
    {
        public static void MergeRegionData(IDataDictionary<StaticRegion> regions, IDataDictionary<StaticPort> ports, IDataDictionary<StaticCity> cities, IDataDictionary<StaticFarm> farms)
        {
            foreach (var region in regions.Data)
            {
                if (region.Value.CanBuildPort)
                {
                    region.Value.Port = ports.Data[region.Value.PortTag];
                }

                region.Value.City = cities.Data[region.Value.CityTag];

                region.Value.Farm = farms.Data[region.Value.FarmTag];
            }
        }
    }
}
