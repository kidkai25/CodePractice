using MvcPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    [Log]
    
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {
            var studentList = new List<Student>
            {
                new Student{Id = 1, Age = 26, StudentName="Shad"},
                new Student{Id = 2, Age = 10, StudentName="Kai"}
            };
            return View(studentList);
        }

        public ActionResult Edit(int? id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            return View();
        }
        //[HandleError]
        public ActionResult Contact()
        {
            string msg = null;
            ViewBag.Message = msg.Length; // this will throw an exception

            return View();
        }
    }
}