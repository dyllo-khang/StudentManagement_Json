using BusinessObject;
using ManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentService() 
        {
            _studentRepository = new StudentRepository();
        }
        public bool AddStudent(StudentProfile student, string filePath) => _studentRepository.AddStudent(student, filePath);

        public bool DeleteStudent(int id, string filePath) => _studentRepository.DeleteStudent(id, filePath);

        public List<StudentProfile> GetAll(string filePath, string search) => _studentRepository.GetAll(filePath, search);

        public StudentProfile GetStudentByID(int id, string filePath) => _studentRepository.GetStudentByID(id, filePath);

        public bool UpdateStudent(StudentProfile student, string filePath) =>_studentRepository.UpdateStudent(student, filePath);

        //public StudentProfile GetUserByEmail(string email, string filePath) => _studentRepository.GetUserByEmail(email, filePath);

    }
}
