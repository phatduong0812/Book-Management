using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance = null;
        private static readonly object instanceLock = new object();

        private EmployeeDAO() { }

        public static EmployeeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Employee> GetListEmployees()
        {
            EmployeeJobTitleContext context = new EmployeeJobTitleContext();
            var list = context.Employees.ToList();
            return list;
        }

        public void DeleteEmployee(string id)
        {
            try
            {
                EmployeeJobTitleContext context = new EmployeeJobTitleContext();
                var employee = context.Employees.FirstOrDefault(x => x.EmployeeId == id);
                if (employee != null)
                {
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This employee does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                EmployeeJobTitleContext context = new EmployeeJobTitleContext();
                var aEm = context.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);             
                if (aEm != null)
                {
                    aEm.EmployeeName = employee.EmployeeName;
                    aEm.YearOfBirth = employee.YearOfBirth;
                    aEm.DepartmentName = employee.DepartmentName;
                    aEm.JobTitleId = employee.JobTitleId;
                    context.Employees.Update(aEm);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This employee does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void NewEmployee(Employee employee)
        {
            try
            {
                EmployeeJobTitleContext context = new EmployeeJobTitleContext();
                var aBook = context.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
                if (aBook == null)
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This EmployeeId already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
