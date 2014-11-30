using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShowCase.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null, "",
                new
                {
                    controller = "Theme",
                    action = "List",
                    name = (string)null,
                    page = 1
                }
            );

            routes.MapRoute(
               null,
               "Page{page}",
                    new { controller = "Theme", 
                          action = "List", 
                          name = (string)null},
                          new { page=@"\d+"}
            );

            routes.MapRoute(
              null,
              "{name}",
                    new
                    {
                        controller = "Theme",
                        action = "List",
                        page = 1
                    }
            );

            routes.MapRoute(null,
                "{name}/Page{page}",
                new { controller = "Theme", action = "List"}, 
                    new {page=@"\d+"}
            );

            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
