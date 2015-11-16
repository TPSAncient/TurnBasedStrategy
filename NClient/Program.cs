using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Core.Data;
using Core.Data.Common;
using Core.Data.World.Country;
using Core.System;
using Core.System.Helpers;
using Core.Test.Data;

namespace NClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedData data = new SeedData();
            data.Path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            data.SaveData();

            SystemManager manager = new SystemManager();
            manager.Path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            manager.Awake();
            StaticCountry c = SelectData.GetDataById(manager.DataCollection.Countries, "country_rome");

            Console.WriteLine(c.Name);

            foreach (var region in manager.DataCollection.Regions.Data)
            {
                Console.WriteLine(region.Value.Farm.Name);
            }

            Console.ReadKey();
        }
    }
}
