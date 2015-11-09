using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Core.System.Helpers
{
    public static class JsonData
    {
        public static T LoadJson<T>(string name)
        {
            string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Data\";
            if (Directory.Exists(folder))
            {
                string json = File.ReadAllText(folder + name + ".json");
                T data = JsonConvert.DeserializeObject<T>(json);
                return data;
            }

            return default(T);
        }

        public static void SaveJson<T>(string name, T obj)
        {
            string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Data\";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(folder + name + ".json", json);
        }
    }
}
