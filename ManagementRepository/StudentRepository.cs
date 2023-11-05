using BusinessObject;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public class StudentRepository : IStudentRepository
    {
        public bool AddStudent(StudentProfile student, string filePath) => StudentDAO.Instance.AddStudent(student, filePath);

        public bool DeleteStudent(int id, string filePath) => StudentDAO.Instance.DeleteStudent(id, filePath);

        public List<StudentProfile> GetAll(string filePath, string search) => StudentDAO.Instance.GetAll(filePath, search);

        public StudentProfile GetStudentByID(int id, string filePath) => StudentDAO.Instance.GetStudentByID(id, filePath);

        public bool UpdateStudent(StudentProfile student, string filePath) => StudentDAO.Instance.UpdateStudent(student, filePath);
        //public StudentProfile GetUserByEmail(string email, string filePath) => StudentDAO.Instance.GetStudentByEmail(email, filePath);


    }
}
