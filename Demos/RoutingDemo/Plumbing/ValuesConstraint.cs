using System;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace RoutingDemo.Plumbing
{
    public class ValuesConstraint : IRouteConstraint
    {
        private readonly string[] validOptions;
        public ValuesConstraint(string options)
        {
            validOptions = options.Split('|');
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.TryGetValue(parameterName, out var value) || value == null) return false;
            
            return validOptions.Contains(value.ToString(), StringComparer.OrdinalIgnoreCase);
        }
    }
}