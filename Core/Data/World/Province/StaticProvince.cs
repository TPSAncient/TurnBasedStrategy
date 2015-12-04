using Core.Data.Common;

namespace Core.Data.World.Province
{
    public class StaticProvince : IData
    {
        public StaticProvince() { }

        public StaticProvince(StaticProvince province)
        {
            Name = province.Name;
            DataType = province.DataType;
            TagName = province.TagName;
        }
        #region IData

        public string Name { get; set; }
        public DataType DataType { get; set; }
        public string TagName { get; set; }

        #endregion
    }
}
