using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeComingMVCFall18.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We love SCC";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "SCC Rocks";

            return View();
        }
    }
}