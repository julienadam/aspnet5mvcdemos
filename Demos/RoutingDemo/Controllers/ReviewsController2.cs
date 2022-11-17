using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    [RoutePrefix("reviews2")]
    public class ReviewsController2 : Controller
    {
        // eg.: /reviews2
        [Route]
        public ActionResult Index() { return Content("All reviews"); }
        // eg.: /reviews2/5
        [Route("{reviewId}")]
        public ActionResult Show(int reviewId) { return Content($"Showing review : {reviewId}"); }
        // eg.: /reviews2/5/edit
        [Route("{reviewId}/edit")]
        public ActionResult Edit(int reviewId) { return Content($"Editing review : {reviewId}"); }
        // eg.: /spotlight-review
        [Route("~/spotlight-review")]
        public ActionResult ShowSpotlight() { return Content($"Spotlight review"); }
    }
}