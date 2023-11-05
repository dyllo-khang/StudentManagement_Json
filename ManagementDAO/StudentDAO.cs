using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class StudentDAO
    {
        private static StudentDAO instance;

        private StudentDAO() { }

        public static StudentDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentDAO();
                }
                return instance;
            }
        }
        public List<StudentProfile> GetAll(string filePath, string search = "")
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                string json = reader.ReadToEnd();
                JsonDocument doc = JsonDocument.Parse(json);
                JsonElement jsonElement = doc.RootElement.GetProperty("students");
                return JsonSerializer.Deserialize<List<StudentProfile>>(jsonElement)
                       .Where(p => p.FullName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            }
        }

        //public StudentProfile GetStudentByEmail(string email, string filePath)
        //{
        //    List<StudentProfile> students = GetAll(filePath);
        //    return students.Find(p => p.Email.Equals(email));
        //}

        public StudentProfile GetStudentByID(int id, string filePath)
        {
            List<StudentProfile> listStudent = GetAll(filePath);
            return listStudent.Find(stu => stu.StudentID.Equals(id));
        }

        public bool AddStudent(StudentProfile student, string filePath)
        {
            List<StudentProfile> students = GetAll(filePath);
            students.Add(student);
            StudentWrapper wrapper = new StudentWrapper();
            wrapper.Students = students;
            string newJson = JsonSerializer.Serialize(wrapper, new JsonSerializerOptions { WriteIndented = true });
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

        public bool UpdateStudent(StudentProfile student, string filePath)
        {
            List<StudentProfile> students = GetAll(filePath);
            StudentProfile stu = students.Find(p => p.StudentID.Equals(student.StudentID));
            if (stu != null)
            {
                stu.FullName = student.FullName;
                stu.Gender = student.Gender;
                stu.Address = student.Address;
                stu.DateOfBirth = student.DateOfBirth;
                stu.Email = student.Email;
                stu.ClassID = student.ClassID;
            }
            StudentWrapper wrapper = new StudentWrapper();
            wrapper.Students = students;
            string newJson = JsonSerializer.Serialize(wrapper, new JsonSerializerOptions { WriteIndented = true });
            try
            {
                File.WriteAllText(filePath, newJson);
                return true;
            }
            catch { return false; }
        }

        public bool DeleteStudent(int id, string filePath)
        {
            List<StudentProfile> students = GetAll(filePath);
            StudentProfile stu = students.Find(p => p.StudentID.Equals(id));
            if (stu != null) students.Remove(stu);
            StudentWrapper wrapper = new StudentWrapper();
            wrapper.Students = students;
            string newJson = JsonSerializer.Serialize(wrapper, new JsonSerializerOptions { WriteIndented = true });
            try
            {
                File.WriteAllText(filePath, newJson);
                return true;
            }
            catch { return false; }
        }
    }
}
