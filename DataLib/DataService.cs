using System.IO;
using System.Text.Json;

namespace RaGae.Game.Blocks.DataLib
{
    public static class DataService
    {
        public static T Read<T>(string filename, JsonSerializerOptions options = null) where T : class
        {
            try
            {
                return JsonSerializer.Deserialize<T>(File.ReadAllText(filename), options);
            }
            catch
            {
                return null;
            }
        }

        public static bool Write<T>(string filename, T data, JsonSerializerOptions options = null)
        {
            try
            {
                File.WriteAllText(filename, JsonSerializer.Serialize(data, options));
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
