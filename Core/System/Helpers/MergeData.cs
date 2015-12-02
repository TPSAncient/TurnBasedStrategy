using System.Collections.Generic;
using System.Linq;
using Core.Data;
using Core.Data.Building;
using Core.Data.Common;
using Core.Data.World;
using Core.Data.World.Region;

namespace Core.System.Helpers
{
    public static class MergeData
    {
        public static void MergeRegionData(DefaultDataCollection collection)
        {
            foreach (var region in collection.Regions.Data)
            {
                //if (region.Value.CanBuildPort)
                //{
                //    region.Value.Port = collection.Ports.Data[region.Value.PortTag];
                //}

                //region.Value.City = collection.Citys.Data[region.Value.CityTag];

                //region.Value.Farm = collection.Farms.Data[region.Value.FarmTag];


                //region.Value.Infrastructure = collection.Infrastructures.Data[region.Value.InfrastructureTag];
            }
        }

        public static void MergeBuildings<T>(IDataDictionary<T> list, IDataDictionary<StaticBuilding> buildings)
        {
            foreach (var data in list.Data)
            {
                var iBuilding = data.Value as IBuilding;
                foreach (var tag in iBuilding.BuildingTag)
                {
                    var building = buildings.Data[tag];
                    //TODO: Fix this
                    //building.IsBuilt = true;
                    //iBuilding.ListOfCompleteBuilding.Data.Add(tag, building);
                }
            }
        }
    }
}
