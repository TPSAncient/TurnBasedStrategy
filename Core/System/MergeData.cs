using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.World;
using Core.Data.World.Location;

namespace Core.System
{
    public class MergeData
    {
        public void MergeRegionData(Dictionary<string, StaticRegion> regions, Dictionary<string, StaticPort> ports, Dictionary<string, StaticCity> cities, Dictionary<string, StaticFarm> farms)
        {
            foreach (var region in regions)
            {
                if (region.Value.CanBuildPort)
                {
                    region.Value.Port = ports[region.Value.PortTag];
                }

                region.Value.City = cities[region.Value.CityTag];

                region.Value.Farm = farms[region.Value.FarmTag];
            }
        }
    }
}
