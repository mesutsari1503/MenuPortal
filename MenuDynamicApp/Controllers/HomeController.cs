using MenuDynamicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuDynamicApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View("~/Views/Home/Contact.cshtml");
        }
        public ActionResult About()
        {
            return View("~/Views/Home/About.cshtml");
        }
    }
}