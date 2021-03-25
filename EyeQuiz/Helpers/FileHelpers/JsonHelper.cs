using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace EyeQuiz.Helpers.FileHelpers
{
    public static class JsonHelper
    {
        private static JsonSerializer Serializer { get; set; }
        public static string FileName { get; set; }

        static JsonHelper()
        {
            Serializer = new JsonSerializer();
        }

        public static void Serialize(Database db)
        {
            using (var fs = new FileStream(FileName, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;

                        Serializer.Serialize(jw, db);
                    }
                }
            }
        }

        public static Database Deserialize()
        {
            Database db = null;
            using (var fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        db = Serializer.Deserialize<Database>(jr);
                    }
                }
            }

            return db;
        }
    }
}