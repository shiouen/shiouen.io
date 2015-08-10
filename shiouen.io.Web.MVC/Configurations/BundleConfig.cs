using System.Web;
using System.Web.Optimization;

namespace shiouen.io.Web.MVC.Configurations {
    public class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(
                new StyleBundle("~/bundles/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/site.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/jquery.fancybox.css"
                )
            );
            bundles.Add(
                new ScriptBundle("~/bundles/js").Include(
                      "~/Content/scripts/jquery-1.10.2.min.js",
                      "~/Content/scripts/classie.js",
                      "~/Content/scripts/bootstrap.min.css",
                      "~/Content/scripts/smoothscroll.js",
                      "~/Content/scripts/jquery.stellar.min.js",
                      "~/Content/scripts/jquery.fancybox.js",
                      "~/Content/scripts/site.js"
                )
            );
        }
    }
}

// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
