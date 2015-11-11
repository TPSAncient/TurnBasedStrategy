using System;
using System.Collections.Generic;
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
            GameManager manager = new GameManager();
            manager.Awake();
            StaticCountry c = SelectData.GetDataById(manager.DataCollection.Countries, DataType.Country, "country_rome");

            Console.WriteLine(c.Name);

            foreach (var region in manager.DataCollection.Regions.Data)
            {
                Console.WriteLine(region.Value.Farm.Name);
            }

            Console.ReadKey();
        }
    }
}
