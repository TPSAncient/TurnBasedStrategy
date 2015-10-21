using System.Collections.Generic;
using Core.Data.World.Location;

namespace Core.Data.World
{
    public class StaticProvince 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ILocation> Locations { get; set; }

        public float ProvinceIncome { get; set; }
        public float ProvinceExpense { get; set; }

        // List of Buildable Spaces

    }
}
