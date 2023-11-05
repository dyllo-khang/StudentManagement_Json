using BusinessObject;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public class UserRepository : IUserRepository
    {
        public bool AddUser(User user, string filePath) => UserDAO.Instance.AddUser(user, filePath);

        public List<User> GetAll(string filePath) => UserDAO.Instance.GetAll(filePath);

        public User GetUserByEmail(string email, string filePath) => UserDAO.Instance.GetUserByEmail(email, filePath);


    }
}
