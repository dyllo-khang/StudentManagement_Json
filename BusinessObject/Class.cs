using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Class
    {
        //public Class() 
        //{
        //    StudentProfiles = new HashSet<StudentProfile>();
        //}
        public string? ClassID { get; set; }
        [JsonPropertyName("name")]
        public string? ClassName { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        //public virtual ICollection<StudentProfile>? StudentProfiles { get; set; }
    }
}
