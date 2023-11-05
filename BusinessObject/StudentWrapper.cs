using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class StudentWrapper
    {
        [JsonPropertyName("students")]
        public List<StudentProfile> Students {  get; set; }

        public StudentWrapper() { }
    }
}
