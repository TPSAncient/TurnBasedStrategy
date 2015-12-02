using Core.Data.Common;

namespace Core.Data.World.Province
{
    public class StaticProvince : IData
    {
        #region IData

        public int Id { get; set; }
        public string Name { get; set; }
        public DataType DataType { get; set; }
        public string TagName { get; set; }

        #endregion
    }
}
