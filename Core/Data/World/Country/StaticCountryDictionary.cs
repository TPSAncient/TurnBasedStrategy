﻿using System.Collections.Generic;

namespace Core.Data.World.Country
{
    public class StaticCountryDictionary : IDataDictionary<StaticCountry>
    {
        public Dictionary<string, StaticCountry> Data { get; set; } = new Dictionary<string, StaticCountry>();
        public void Add(string key, StaticCountry value)
        {
            Data.Add(key, value);
        }

        public DataType DataType { get; set; } = DataType.Country;
    }
}