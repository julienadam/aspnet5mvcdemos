using System;
using System.Globalization;
using System.Web;
using System.Web.Routing;

namespace RoutingDemo.Plumbing
{
    public class DateRouteConstraint : IRouteConstraint
    {
        public bool Match(
            HttpContextBase httpContext, 
            Route route, 
            string parameterName, 
            RouteValueDictionary values, 
            RouteDirection routeDirection) =>
            DateTime.TryParseExact(
                values[parameterName].ToString(),
                "yyyyMMdd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out _);
    }
}