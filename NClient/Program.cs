using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Core.Data.World.Location;
using Core.System;
using Core.System.Helpers;
using Core.Test.Data;

namespace NClient
{
    class Program
    {
        static void Main(string[] args)
        {

            //SeedData data = new SeedData();
            //data.SaveData();

            //Dictionary<string, StaticCity> cities = JsonData.LoadJson<Dictionary<string, StaticCity>>("Citys");
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city.Value.TagName);
            //}

            GameManager manager = new GameManager();
            manager.Awake();

            foreach (var region in manager.Regions)
            {
                Console.WriteLine(region.Value.Farm.Name);
            }

            Console.ReadKey();
        }
    }
}
