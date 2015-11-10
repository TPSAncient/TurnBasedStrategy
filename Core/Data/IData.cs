using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Core.Data
{
    public interface IData
    {
        int Id { get; set; }
        string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        DataType DataType { get; set; }
    }
}
