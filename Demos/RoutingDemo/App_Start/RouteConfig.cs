using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;
using RoutingDemo.Plumbing;

namespace RoutingDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutesDoublon(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        public static void RegisterRoutesOrdre(RouteCollection routes)
        {
            // /Foo/Bar pointe sur FooController.Index()
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            // /Foo/Bar pointe sur HomeController.About()
            routes.MapRoute(
                name: "Custom",
                url: "Foo/Bar",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );
        }

        private static void RegisterDefaultRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        private static void RegisterExistingConstraint(RouteCollection routes)
        {
            routes.MapRoute(
                name: "year month",
                url: "{year}/{month}",
                defaults: new { controller = "Home", action = "YearMonth" },
                constraints: new { year = @"\d{4}", month = new RangeRouteConstraint(1, 12) });
        }

        private static void RegisterCustomConstraint(RouteCollection routes)
        {
            routes.MapRoute(
                name: "date",
                url: "{date}",
                defaults: new { controller = "Home", action = "Date" },
                constraints: new { date = new DateRouteConstraint() });
        }

        private static void RegisterCatchall(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Default with catchall",
                url: "{controller}/{action}/{id}/{*catchall}",
                defaults: new
                    { controller = "Home", action = "Index", id = UrlParameter.Optional, catchall = UrlParameter.Optional }
            );
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            var constraintsResolver = new DefaultInlineConstraintResolver();
            constraintsResolver.ConstraintMap.Add("values", typeof(ValuesConstraint));
            routes.MapMvcAttributeRoutes(constraintsResolver);
            
            RegisterDefaultRoutes(routes);

            // RegisterRoutesDoublon(routes);
            // RegisterRoutesOrdre(routes);
            // RegisterExistingConstraint(routes);
            // RegisterCustomConstraint(routes);
            // RegisterCatchall(routes);
        }
    }
}
