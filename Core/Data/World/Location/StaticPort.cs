﻿namespace Core.Data.World.Location
{
    public class StaticPort : ILocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LocationType LocationType { get; set; }
        public string TagName { get; set; }
    }
}
