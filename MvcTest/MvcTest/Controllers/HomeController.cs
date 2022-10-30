using MvcTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult CreateEmployee()
        {
            //Get Last Added Employee
            EmployeeDbContext employeeDbContext = new EmployeeDbContext();
            Employee employee = employeeDbContext.Employees.OrderByDescending(x => x.Id)
                                                           .FirstOrDefault();
            return View(employee);
        }

        [HttpPost]
        public ActionResult CreateEmployee(Employee employee)
        {

            EmployeeDbContext employeeDbContext = new EmployeeDbContext();
            employeeDbContext.Employees.Add(employee);

            employeeDbContext.SaveChanges();
            return View(employee);
        }
    }
}