using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class TemperatureController : Controller
    {
        // eg: temp/celsius and /temp/fahrenheit but not /temp/kelvin
        [Route("temp/{scale:values(celsius|fahrenheit)}")]
        public ActionResult Show(string scale)
        {
            return Content("scale is " + scale);
        }
    }
}