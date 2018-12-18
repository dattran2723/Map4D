using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Map4D
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "url_login",
                url: "login",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "Map4D.Controllers" }
            );
            routes.MapRoute(
                name: "CheckExistUserName",
                url: "CheckExistUserName",
                defaults: new { controller = "Account", action = "CheckExistUserName", id = UrlParameter.Optional },
                namespaces: new[] { "Map4D.Controllers" }
            );
            routes.MapRoute(
                name: "checkExistEmail",
                url: "checkExistEmail",
                defaults: new { controller = "Account", action = "CheckExistEmail", id = UrlParameter.Optional },
                namespaces: new[] { "Map4D.Controllers" }
            );

            routes.MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Map4D.Controllers" }
            );
        }
    }
}
