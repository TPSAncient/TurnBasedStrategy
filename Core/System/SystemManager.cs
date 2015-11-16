﻿using System.Collections.Generic;
using Core.Data;
using Core.Data.Actor;
using Core.Data.Common;
using Core.Data.World;
using Core.Data.World.Country;
using Core.Data.World.Province;
using Core.Data.World.Region;
using Core.System.Helpers;
using Core.Test.Data;

namespace Core.System
{
    /// <summary>
    /// Start class
    /// </summary>
    public class SystemManager : UnityMonoBehaviour
    {
        #region Variables

        public IDataDictionary<StaticActor> Players
        {
            get { return DataCollection.Players; }
            set { DataCollection.Players = value; }
        }

        public IDataDictionary<StaticCountry> Countries
        {
            get { return DataCollection.Countries; }
            set { DataCollection.Countries = value; }
        }

        public IDataDictionary<StaticProvince> Provinces
        {
            get { return DataCollection.Provinces; }
            set { DataCollection.Provinces = value; }
        }

        public IDataDictionary<StaticRegion> Regions
        {
            get { return DataCollection.Regions; }
            set { DataCollection.Regions = value; }
        }

        public IDataDictionary<StaticCity> Citys
        {
            get { return DataCollection.Citys; }
            set { DataCollection.Citys = value; }
        }

        public IDataDictionary<StaticFarm> Farms
        {
            get { return DataCollection.Farms; }
            set { DataCollection.Farms = value; }
        }

        public IDataDictionary<StaticPort> Ports
        {
            get { return DataCollection.Ports; }
            set { DataCollection.Ports = value; }
        }

        #endregion

        public DataCollection DataCollection { get; set; } = new DataCollection();

        public override void Awake()
        {
            Load();
            Merge();
        }

        public void Load()
        {
            // For populatind data files with basic data
            SeedData data = new SeedData();
            data.SaveData();

            DataCollection.Players = LoadData.Load<StaticDictionary<StaticActor>>(Constants.PlayersFileName);
            DataCollection.Countries = LoadData.Load<StaticDictionary<StaticCountry>>(Constants.CountriesFileName);
            DataCollection.Provinces = LoadData.Load<StaticDictionary<StaticProvince>>(Constants.ProvincesFileName);
            DataCollection.Regions = LoadData.Load<StaticDictionary<StaticRegion>>(Constants.RegionsFileName);
            DataCollection.Citys = LoadData.Load<StaticDictionary<StaticCity>>(Constants.CitysFileName);
            DataCollection.Farms = LoadData.Load<StaticDictionary<StaticFarm>>(Constants.FarmsFileName);
            DataCollection.Ports= LoadData.Load<StaticDictionary<StaticPort>>(Constants.PortsFileName);
            DataCollection.Infrastructures= LoadData.Load<StaticDictionary<StaticInfrastructure>>(Constants.InfrastructureFileName);
        }

        public void Merge()
        {
            MergeData.MergeRegionData(DataCollection.Regions, DataCollection.Ports, DataCollection.Citys, DataCollection.Farms);
        }
        
    }
}