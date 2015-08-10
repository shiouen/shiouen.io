using System;
using System.Collections.Generic;
using System.Web.Mvc;

using shiouen.io.Web.MVC.Helpers;

namespace shiouen.io.Web.MVC.Controllers {
    public class HomeController : Controller {

        // GET: ""
        public ActionResult Show() { return View("~/Views/Home/Index.cshtml"); }
    }
}
