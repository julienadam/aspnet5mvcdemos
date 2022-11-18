using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TestCookie()
        {
            // Response.SetCookie(new HttpCookie("clé", "valeur"));
            Response.SetCookie(new HttpCookie("clef", "valeur spéciale"));
            return View();
        }

        public ActionResult TestSession()
        {
            Session["clé"] = "valeur";
            return View();
        }

        public ActionResult TestSession2()
        {
            return View("TestSession");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestTempData1()
        {
            TempData["clé"] = 42;
            return RedirectToAction("TestTempData2");
        }

        public ActionResult TestTempData2()
        {
            return Content(TempData["clé"]?.ToString());
        }

        public ActionResult TestTempData3()
        {
            return Content(TempData["clé"]?.ToString());
        }
    }
}