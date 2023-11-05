using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public interface IStudentService
    {
        List<StudentProfile> GetAll(string filePath, string search);
        //StudentProfile GetUserByEmail(string email, string filePath);
        bool AddStudent(StudentProfile student, string filePath);
        StudentProfile GetStudentByID(int id, string filePath);
        bool UpdateStudent(StudentProfile student, string filePath);
        bool DeleteStudent(int id, string filePath);
    }
}
