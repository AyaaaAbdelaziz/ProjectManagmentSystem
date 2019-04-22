using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectManagementSystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute("Customer/Action1", "Customer/Action1/{index}", new { controller = "Customer", action = "Action1", index = UrlParameter.Optional });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "customer", // Route name
                "{controller}/{action}", // URL with parameters
                new { controller = "Cust", action = "cut" } // Parameter defaults
            );
            routes.MapRoute(
               "chome", // Route name
               "{controller}/{action}", // URL with parameters
               new { controller = "Home", action = "CHome" } // Parameter defaults
           );
            routes.MapRoute(
             "signin", // Route name
             "{controller}/{action}", // URL with parameters
             new { controller = "Home", action = "signin" } // Parameter defaults
         );
        }
    }
}
