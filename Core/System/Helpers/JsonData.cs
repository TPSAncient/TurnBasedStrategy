using System.IO;
using Newtonsoft.Json;

namespace Core.System.Helpers
{
    public static class JsonData
    {
        public static T LoadJson<T>(string name)
        {
            string json = File.ReadAllText(@"c:\" + name + ".json");
            T data = JsonConvert.DeserializeObject<T>(json);
            return data;
        }

        public static void SaveJson<T>(string name, T obj)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(@"c:\" + name + ".json", json);
        }
    }
}
