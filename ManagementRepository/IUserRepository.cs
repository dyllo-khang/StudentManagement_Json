using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public interface IUserRepository
    {
        List<User> GetAll(string filePath);
        User GetUserByEmail(string email, string filePath);
        bool AddUser(User user, string filePath);
    }
}
