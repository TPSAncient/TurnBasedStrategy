﻿using Core.Data.Common;
using Core.Data.World.Region;

namespace Core.Test.Data
{
    public class SeedRegionData
    {
        public StaticDictionary<StaticRegion> Regions;

        public SeedRegionData()
        {
            Regions = new StaticDictionary<StaticRegion>();

            StaticRegion region;

            region = AddRegion("Roma Port", "port_roma", true);
            region = AddRegionLocations(region, "city_roma", "farm_roma", "port_roma", "infrastructure_roma", "province_italia");
            Regions.Add(region.TagName, region);

            region = AddRegion("Velathri Port", "port_velathri", true);
            region = AddRegionLocations(region, "city_velathri", "farm_velathri", "port_velathri", "infrastructure_velathri", "province_italia");
            Regions.Add(region.TagName, region);

            region = AddRegion("Ariminum Port", "port_ariminum", true);
            region = AddRegionLocations(region, "city_ariminum", "farm_ariminum", "port_ariminum", "infrastructure_ariminum", "province_italia");
            Regions.Add(region.TagName, region);
        }
         
        private StaticRegion AddRegion(string name, string tagName, bool canBuildPort)
        {
            StaticRegion region = new StaticRegion();

            region.Name = name;
            region.TagName = tagName;
            region.CanBuildPort = canBuildPort;
            region.DataType = DataType.Region;
            return region;
        }

        private StaticRegion AddRegionLocations(StaticRegion region, string cityTag, string farmTag, string portTag, string infrastructureTag, string provinceTag)
        {
            region.CityTag = cityTag;
            region.FarmTag = farmTag;
            region.PortTag = portTag;
            region.InfrastructureTag = infrastructureTag;
            region.ProvinceTag = provinceTag;
            return region;
        }
    }
}