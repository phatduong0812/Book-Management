using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Add(Employee employee) => EmployeeDAO.Instance.NewEmployee(employee);

        public void Delete(string id) => EmployeeDAO.Instance.DeleteEmployee(id);

        public List<Employee> GetLists() => EmployeeDAO.Instance.GetListEmployees();

        public void Update(Employee employee) => EmployeeDAO.Instance.UpdateEmployee(employee);
    }
}
