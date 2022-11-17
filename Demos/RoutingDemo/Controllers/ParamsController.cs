using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public enum Couleur
    {
        Rouge,
        Vert,
        Bleu
    }

    public class ParamsController : Controller
    {
        public ActionResult Index(int blah, Couleur c, bool truc = false)
        {
            return Content($"{blah}, {c}, {truc}");
        }

        // Params/Index?blah=42&c=rouge&truc=true
        // Params/Index?blah=42&c=jaune&truc=true
        // Params/Index?blah=42&c=-42&truc=true
        // Params/Index?blah=42&c=rouge&truc=1
        // Params/Index?blah=truc&c=rouge&truc=true
    }
}
   

