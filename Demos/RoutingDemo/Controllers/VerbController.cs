using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class VerbController : Controller
    {
        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string query)
        {
            return Content($"Résultats de recherche pour :{query}");
        }
    }
}