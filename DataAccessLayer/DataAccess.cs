using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class DataAccess
    {
        private readonly EmployeeDbContext _DbContext;

        public DataAccess(EmployeeDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {

            try
            {
                return _DbContext.Employee;

            }
            catch (Exception)
            {

                throw;

            }


        }
        public Employee GetEmployee(int id)
        {

            try
            {
                return _DbContext.Employee.FirstOrDefault(x => x.ID == id);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public int CreateEmployee(Employee employee)
        {
            int count = 0;
            try
            {
                _DbContext.Employee.Add(employee);
                count = _DbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return count;
        }

        public int UpdateEmployee(Employee employee)
        {
            int count = 0;
            try
            {
                _DbContext.Employee.Update(employee);
                count = _DbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return count;
        }

        public int DeleteEmployee(int id)
        {
            int count = 0;
            try
            {
                _DbContext.Employee.Remove(_DbContext.Employee.FirstOrDefault(e => e.ID == id));
                count = _DbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return count;
        }
    }
}
