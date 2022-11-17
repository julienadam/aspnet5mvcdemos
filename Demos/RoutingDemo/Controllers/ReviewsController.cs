using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class ReviewsController : Controller
    {
        // eg: /reviews
        [Route("reviews")]
        public ActionResult Index()
        {
            return Content("All reviews");
        }

        // eg: /reviews/5
        [Route("reviews/{reviewId}")]
        public ActionResult Show(int reviewId)
        {
            return Content($"Showing review : {reviewId}");
        }

        // eg: /reviews/5/edit
        [Route("reviews/{reviewId}/edit")]
        public ActionResult Edit(int reviewId)
        {
            return Content($"Editing review : {reviewId}");
        }
    }
}