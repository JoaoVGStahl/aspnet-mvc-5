using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstMVC5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            /*
            routes.MapRoute(
                name: "Institucional",
                url: "institucional/{controller}/{action}",
                defaults: new { controller = "Teste", action = "IndexTeste"}
            );

            routes.MapRoute(
                name: "Teste",
                url: "sistema/{controller}/{action}/{id}",
                defaults: new { controller = "Teste", action = "IndexTeste", id = UrlParameter.Optional }
            );
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
