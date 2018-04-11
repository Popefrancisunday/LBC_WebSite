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
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Campus()
        {
            return View();
        }
        public ActionResult EvangelicalMinistry()
        {
            return View();
        }
        public ActionResult PrayingMinistry()
        {
            return View();
        }
        public ActionResult Worship()
        {
            return View();
        }
        public ActionResult StewardMinistry()
        {
            return View();
        }
        public ActionResult Chaplaincy()
        {
            ViewBag.Message = "St. Abert De Great Chaplaincy";
            return View();

        }

    }
}