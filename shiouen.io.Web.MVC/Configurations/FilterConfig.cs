using System.Web;
using System.Web.Mvc;

namespace shiouen.io.Web.MVC.Configurations {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
