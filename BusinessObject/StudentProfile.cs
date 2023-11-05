using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class StudentProfile
    {
        public int StudentID { get; set; }
        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [JsonPropertyName("gender")]
        public string? Gender { get; set; }
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        public string? ClassID { get; set; }

        //public virtual Class? Class { get; set; }
    }
}

