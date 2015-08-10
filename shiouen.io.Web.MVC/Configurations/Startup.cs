using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

[assembly: OwinStartup(typeof(shiouen.io.Web.MVC.Configurations.Startup))]

namespace shiouen.io.Web.MVC.Configurations {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
