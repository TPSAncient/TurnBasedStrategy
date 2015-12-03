using Core.Data.Common;

namespace Core.Data.World.Province
{
    public class StaticProvince : IData
    {
        #region IData

        public string Name { get; set; }
        public DataType DataType { get; set; }
        public string TagName { get; set; }

        #endregion
    }
}
