using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityFramework;

namespace BusinessLogic
{
    public class EmployeeBL
    {
        private readonly DataAccess _employeeDL;

        public EmployeeBL(DataAccess employeeDAL)
        {
            _employeeDL = employeeDAL;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeDL.GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {

            return _employeeDL.GetEmployee(id);

        }

        public int CreateEmployee(Employee employee)
        {
            return _employeeDL.CreateEmployee(employee);
        }

        public int UpdateEmployee(Employee employee)
        {
            return _employeeDL.UpdateEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
            return _employeeDL.DeleteEmployee(id);
        }
    }
}
