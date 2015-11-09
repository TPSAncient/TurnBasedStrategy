using System.Collections.Generic;
using Core.Data;
using Core.Data.World;
using Core.Data.World.Location;
using Core.System.Helpers;
using Core.Test.Data;

namespace Core.System
{
    /// <summary>
    /// Start class
    /// </summary>
    public class GameManager : UnityMonoBehaviour
    {
        public Dictionary<int, StaticPlayer> Players { get; set; }
        public Dictionary<string, StaticCountry> Countries { get; set; }
        public Dictionary<string, StaticProvince> Provinces { get; set; }
        public Dictionary<string, StaticRegion> Regions { get; set; }
        public Dictionary<string, StaticCity> Citys { get; set; }
        public Dictionary<string, StaticFarm> Farms { get; set; }
        public Dictionary<string, StaticPort> Ports { get; set; }

        public override void Awake()
        {
            SeedData data = new SeedData();
            Players = data.Players;
            Countries = data.Countries;
            Provinces = data.Provinces;
            Regions = data.Regions;
            Citys = data.Citys;
            Farms = data.Farms;
            Ports = data.Ports;
        }

        
    }
}
