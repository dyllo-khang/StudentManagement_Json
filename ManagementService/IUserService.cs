using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public interface IUserService
    {
        List<User> GetAll(string filePath);

        User GetUserByEmail(string email, string passWord, string filePath);
        bool AddUser(User user, string filePath);
    }
}
