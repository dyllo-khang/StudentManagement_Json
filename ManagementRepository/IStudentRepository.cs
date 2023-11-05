using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public interface IStudentRepository
    {
        List<StudentProfile> GetAll(string filePath, string search);
        //StudentProfile GetStudentByEmail(string email, string filePath);
        StudentProfile GetStudentByID(int id, string filePath);
        bool AddStudent(StudentProfile student, string filePath);

        bool UpdateStudent(StudentProfile student, string filePath);

        bool DeleteStudent(int id, string filePath);
    }
}
