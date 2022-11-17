using System;
using System.Globalization;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult YearMonth(int year, int month)
        {
            return Content(new DateTime(year, month, 1).ToString());
        }

        public ActionResult Date(string date)
        {
            return Content(DateTime.ParseExact(date, "yyyyMMdd", CultureInfo.InvariantCulture).ToString());
        }

        public ActionResult TestCatchAll()
        {
            return Content(RouteData.Values["catchall"]?.ToString());
        }

        public ActionResult Index()
        {
            return Content($"{RouteData.Values["controller"]}::{RouteData.Values["action"]}::{RouteData.Values["id"]}");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}