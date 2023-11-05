using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class ClassDAO
    {
        private static ClassDAO instance;

        private ClassDAO() { }

        public static ClassDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClassDAO();
                }
                return instance;
            }
        }
        public List<Class> GetAll(string filePath)
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                string json = reader.ReadToEnd();
                JsonDocument doc = JsonDocument.Parse(json);
                JsonElement jsonElement = doc.RootElement.GetProperty("classes");
                return JsonSerializer.Deserialize<List<Class>>(jsonElement);
            }
        }
    }
}
