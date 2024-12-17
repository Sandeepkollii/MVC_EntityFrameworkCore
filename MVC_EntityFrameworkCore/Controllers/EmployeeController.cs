using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EntityFrameworkCore.Context;
using MVC_EntityFrameworkCore.Models;

namespace MVC_EntityFrameworkCore.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDbContext _dbComtext;

        public EmployeeController(EmployeeDbContext context)
        {
            _dbComtext = context;
        }

        public ActionResult Index()
        {
            return View(_dbComtext.Employee.ToList());
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View(_dbComtext.Employee.Where(x => x.ID == id).FirstOrDefault());
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {
                _dbComtext.Employee.Add(emp);
                _dbComtext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee emp1 = _dbComtext.Employee.Where(x => x.ID == id).FirstOrDefault();
            return View(emp1);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                Employee emp2 = _dbComtext.Employee.Where(x => x.ID == id).FirstOrDefault();
                emp2.Salary = emp.Salary;
                emp2.Dept = emp.Dept;
                _dbComtext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var emp3 = _dbComtext.Employee.Where(x => x.ID == id).FirstOrDefault();

            return View(emp3);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee emp)
        {
            try
            {
                var emp4 = _dbComtext.Employee.Where(x => x.ID == id).FirstOrDefault();
                _dbComtext.Employee.Remove(emp4);
                _dbComtext.SaveChanges();
                return RedirectToAction(nameof(Index));


            }
            catch
            {
                return View();
            }
        } 
    }
}
