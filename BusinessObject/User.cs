using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("fullname")]
        public string? FullName { get; set; }
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        [JsonPropertyName("password")]
        public string? PassWord { get; set; }
        [JsonPropertyName("role")]
        public int Role {  get; set; }

        public User() { }
        public User(int id, string fullName, string email, string passWord, int role)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            PassWord = passWord;
            Role = role;
        }
    }
}
