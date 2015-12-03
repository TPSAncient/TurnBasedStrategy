using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Common;

namespace Core.Data.World
{
    public class StaticTerrain : IData
    {
        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }
    }
}
