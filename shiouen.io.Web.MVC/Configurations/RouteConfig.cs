using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace shiouen.io.Web.MVC.Configurations {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* Home */
            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Show" },
                constraints: new { controller = "Home", action = "Show" }
            );
        }
    }
}
