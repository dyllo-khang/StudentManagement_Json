using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        private UserDAO() { }

        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        public List<User> GetAll(string filePath)
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                string json = reader.ReadToEnd();
                JsonDocument doc = JsonDocument.Parse(json);
                JsonElement jsonElement = doc.RootElement.GetProperty("users");
                return JsonSerializer.Deserialize<List<User>>(jsonElement);
            }
        }

        public User GetUserByEmail(string email, string filePath)
        {
            List<User> users = GetAll(filePath);
            return users.Find(p => p.Email.Equals(email));
        }

        public bool AddUser(User user, string filePath)
        {
            List<User> users = GetAll(filePath);
            users.Add(user);
            UserWrapper wrapper = new UserWrapper();
            wrapper.Users = users;
            string newJson = JsonSerializer.Serialize(wrapper, new JsonSerializerOptions { WriteIndented = true});
            try
            {
                File.WriteAllText(filePath, newJson);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
