using System.Web.Mvc;
using ViewsDemo.Models;

namespace ViewsDemo.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                return Content("Success");
            }

            return View(product);
        }
    }
}