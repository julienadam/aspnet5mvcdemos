using DemoTests;
using System.Web.Routing;
using RoutingDemo;
using Xunit;

namespace RoutingDemoTests
{
    public class RoutingTests
    {
        [Fact]
        public void FailingRouteTest()
        {
            // Arrange
            // Create a fake context and set it up
            var context = new StubHttpContextForRouting("/", "~/");
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            
            // Act
            var routeData = routes.GetRouteData(context);

            // Assert
            RouteTestingHelper.AssertRouteData(routeData, "Home", "List", "");
        }
    }
}
