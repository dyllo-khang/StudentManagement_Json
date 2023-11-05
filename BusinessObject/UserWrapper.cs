using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserWrapper
    {
        [JsonPropertyName("users")]
        public List<User> Users { get; set; }

        public UserWrapper() { }
    }
}
