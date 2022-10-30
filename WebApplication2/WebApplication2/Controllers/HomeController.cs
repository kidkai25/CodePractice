using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost] //To get client and server time?
        public ActionResult IndexPost()
        {
            var serverDateTime = DateTime.Now;

            //creating string for server Time


            return Json(new { ServerDateTime = serverDateTime });
            //return View();
        }
    }
}