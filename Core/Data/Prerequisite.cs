using Core.Data.Common;

namespace Core.Data
{
    public class Prerequisite : IData
    {
        public string Name { get; set; }
        public string TagName { get; set; }
        public DataType DataType { get; set; }
        
    }
}