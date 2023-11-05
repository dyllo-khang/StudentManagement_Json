using BusinessObject;
using ManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;

        public UserService()
        {
            _repository = new UserRepository();
        }

        public bool AddUser(User user, string filePath) => _repository.AddUser(user, filePath);

        public List<User> GetAll(string filePath) => _repository.GetAll(filePath);

        public User GetUserByEmail(string email, string passWord, string filePath)
        {
            User user = _repository.GetUserByEmail(email, filePath);
            if(user != null)
            {
                if(user.PassWord.Equals(passWord)) return user;
            }
            return null;
        }
    }
}
