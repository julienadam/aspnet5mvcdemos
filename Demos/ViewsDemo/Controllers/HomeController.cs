using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsDemo.Models;

namespace ViewsDemo.Controllers
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

        public ActionResult ServerInfo()
        {
            var serverInfo = new ServerInfoViewModel
            {
                Cores = Environment.ProcessorCount,
                MachineName = Environment.MachineName,
                OperatingSystem = Environment.OSVersion.ToString(),
                CLRVersion = Environment.Version.ToString(),
            };

            return PartialView("ServerInfo/ServerInfo", serverInfo);
        }
    }
}