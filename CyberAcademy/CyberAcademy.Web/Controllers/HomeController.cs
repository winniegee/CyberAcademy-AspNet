using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberAcademy.Web.Controllers
{
    public class HomeController : Controller
    {
        [ChildActionOnly]
        public ActionResult SomePage()
        {
            return PartialView();
        }
        // GET: Home
        public ActionResult Index()
        {
            this.ViewData["Male"] = Url.Content("~/images/profile.png");

            this.ViewData["Female"] = Url.Content("~/images/profile2.png");

            this.ViewBag.Styles = "border: 1px solid green;";
            return View();
        }

    }
}