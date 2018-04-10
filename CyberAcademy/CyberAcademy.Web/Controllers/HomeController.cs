using CyberAcademy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberAcademy.Web.Controllers
{

    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult GetSearchForm(SearchModel model)
        {
            TempData["Keyword"] = model;
            return RedirectToAction("SearchForm");
        }

        [HttpGet]
        public ActionResult SearchForm()
        {
            if (TempData["Keyword"] == null)
                return View();

            var word = (SearchModel)TempData["Keyword"];
            var checkText = word.RememberMe ? "Checked" : "Not Checked";
            ViewData["Keyword"] = $"{word.Keyword} & Remember Me: {checkText}";
            return View();
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