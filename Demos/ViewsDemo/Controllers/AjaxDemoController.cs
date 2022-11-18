using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ViewsDemo.Controllers
{
    public class AjaxDemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Work()
        {
            // Action longue
            Thread.Sleep(5000);
            return Content("Finished!");
        }
    }
}