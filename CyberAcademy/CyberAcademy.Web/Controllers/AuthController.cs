using CyberAcademy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberAcademy.Web.Controllers
{
   [AllowAnonymous]
    public class AuthController : Controller
    {
        [HttpPost]
        public ActionResult Login(LoginInfo data)
        {
            var username = data.Username;
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}