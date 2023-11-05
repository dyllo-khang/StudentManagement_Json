using BusinessObject;
using ManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public class ClassService : IClassService
    {
        private IClassRepository repository;
        public ClassService() 
        { 
            repository = new ClassRepository();
        }

        public List<Class> GetAll(string filePath) => repository.GetAll(filePath);
    }
}
