using System.Web.Routing;
using Xunit;

namespace DemoTests
{
    public static class RouteTestingHelper
    {
        public static void AssertRouteData(RouteData routeData, string controller, string action, string id)
        {
            Assert.NotNull(routeData);
            Assert.Equal(controller, routeData.Values["controller"]);
            Assert.Equal(action, routeData.Values["action"]);
            Assert.Equal(id, routeData.Values["id"]);
        }
    }
}