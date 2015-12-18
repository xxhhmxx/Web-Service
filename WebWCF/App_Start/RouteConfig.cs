using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebWCF
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Add Cart",
                url: "them-san-pham",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
                namespaces: new[] { "WebWCF.Controllers" }
            );

            routes.MapRoute(
                name: "Total",
                url: "thanh-toan",
                defaults: new { controller = "Cart", action = "Total", id = UrlParameter.Optional },
                namespaces: new[] { "WebWCF.Controllers" }
            );

            routes.MapRoute(
               name: "Type",
               url: "san-pham",
               defaults: new { controller = "Home", action = "Type", id = UrlParameter.Optional },
               namespaces: new[] { "WebWCF.Controllers" }
           );

            routes.MapRoute(
               name: "Remove Cart",
               url: "remove",
               defaults: new { controller = "Cart", action = "RemoveFromCart", id = UrlParameter.Optional },
               namespaces: new[] { "WebWCF.Controllers" }
           );
            routes.MapRoute(
               name: "Search",
               url: "search",
               defaults: new { controller = "Home", action = "Search", id = UrlParameter.Optional },
               namespaces: new[] { "WebWCF.Controllers" }
           );
        }
    }
}
