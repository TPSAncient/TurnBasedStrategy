using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Core.Data.Common
{
    public interface IData
    {
        string Name { get; set; }
        string TagName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        DataType DataType { get; set; }
    }
}
