using System;
using System.Diagnostics;
using System.IO;
using Core.Data.World.Country;
using Core.System;
using Core.System.DataSystem;
using Core.System.Helpers;
using Core.System.SelectSystem;
using Core.System.TurnSystem;
using Core.Test.Data;

namespace NClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //SeedData data = new SeedData(new DataManager());
            //data.Path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            //data.SaveData();

            //SystemManager manager = new SystemManager(new TurnManager(), new SelectManager());
            //manager.Path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            //manager.Awake();
            //StaticCountry c = SelectData.GetDataById(manager.DataCollection.Countries, "country_rome");

            //Console.WriteLine(c.Name);

            //foreach (var region in manager.DataCollection.Regions.Data)
            //{
            //    if (region.Value.Infrastructure.ListOfCompleteBuilding.Data != null)
            //    {
            //        foreach (var building in region.Value.Infrastructure.ListOfCompleteBuilding.Data)
            //        {
            //            Console.WriteLine(building.Value.Name);
            //        }
            //    }
                

            //    Console.WriteLine(region.Value.Infrastructure.Name);
            //}

            //Console.ReadKey();
        }
    }
}
