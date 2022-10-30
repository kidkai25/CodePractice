using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adonet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmpRepository empRepository = new EmpRepository();            
            return View(empRepository.GetAllEmployees());
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Adonet.Models.EmpModel Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpRepository empRepo = new EmpRepository();

                    if (empRepo.AddEmployee(Emp))
                    {
                        ViewBag.Message = "Employee Details Added Successfully";
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}