using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Cuisine",
                url: "cuisine/{name}",
                defaults: new { Controller = "Cuisine", action = "Search", name = "" }
                );

            routes.MapRoute(
                name: "Car",
                url: "car/{brand}/{model}",
                defaults: new { Controller = "Car", action = "Brand", name = "", model = "",
                brand = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
