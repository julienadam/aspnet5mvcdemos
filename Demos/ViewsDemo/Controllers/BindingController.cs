using System;
using System.Web.Mvc;
using ViewsDemo.Models;

namespace ViewsDemo.Controllers
{
    public class BindingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Input(FormCollection coll)
        {
            var result =
                $"From request Form : {Request.Form["Nom"]}" +
                $"From request Params : {Request.Params["Nom"]}" +
                $"From FormCollection : {coll["Nom"]}";
            return Content(result);
        }

        [HttpPost]
        public ActionResult Bind(Client c)
        {
            var result =
                $"From bound model {c.Nom}";
            return Content(result);
        }
    }
}