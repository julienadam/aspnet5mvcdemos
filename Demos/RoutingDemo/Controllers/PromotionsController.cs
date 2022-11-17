using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    [RoutePrefix("promotions")]
    [Route("{action=index}")]
    public class PromotionsController : Controller
    {
        // eg.: /promotions
        public ActionResult Index() { return Content("Index"); }

        // eg.: /promotions/archive
        public ActionResult Archive() { return Content("Archive"); }

        // eg.: /promotions/new
        public ActionResult New() { return Content("New"); }

        // eg.: /promotions/edit/5
        [Route("edit/{promoId:int}")]
        public ActionResult Edit(int promoId) { return Content($"Editing {promoId}"); }
    }
}