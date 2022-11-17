using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class UsersController : Controller
    {
        // eg: /users/5
        [Route("users/{id:int}")]
        // [Route("users/{id:int:min(1)}")] 
        public ActionResult GetUserById(int id) => Content($"User by id {id}");

        // eg: users/ken
        [Route("users/{name}")]
        public ActionResult GetUserByName(string name) => Content($"User by name {name}");
        
        // eg: /greetings/bye
        // and /greetings because of the Optional modifier,
        // but not /greetings/see-you-tomorrow because of the maxlength(3) constraint.
        [Route("greetings/{message:maxlength(3)?}")]
        public ActionResult Greet(string message) => Content($"{message}");
    }
}