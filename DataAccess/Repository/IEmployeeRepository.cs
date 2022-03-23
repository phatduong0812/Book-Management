using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetLists();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(string id);
    }
}
