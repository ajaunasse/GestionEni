using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GestionEni
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(null, "{controller}/{action}");

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Login", 
                url: "Login",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "list_personne",
                url: "Admin/Personne",
                defaults: new { controller = "Personne", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "create_personne",
                url: "Admin/Personne/Create",
                defaults: new { controller = "Personne", action = "Create", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "edit_personne",
                url: "Admin/Personne/Edit/{id}",
                defaults: new { controller = "Personne", action = "Edit", id = 2}
            );
        }
    }
}