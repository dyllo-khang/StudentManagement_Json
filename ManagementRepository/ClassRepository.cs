using BusinessObject;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public class ClassRepository : IClassRepository
    {
        public List<Class> GetAll(string filePath) => ClassDAO.Instance.GetAll(filePath);
    }
}
