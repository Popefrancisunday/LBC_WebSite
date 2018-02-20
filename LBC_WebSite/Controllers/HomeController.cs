using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LBC_WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Light Bearer's Community ESUT.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Campus()
        {
            ViewBag.Message = "Various Campuses.";
            return View();
        }
        public ActionResult Ministry()
        {
            ViewBag.Message = "Ministries in LBC.";
            return View();
        }
    }
}