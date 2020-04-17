using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MenuDynamicApp.Models;

namespace MenuDynamicApp.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View("~/Views/Account/Login.cshtml");
        }
        public ActionResult Registration()
        {
            return View("~/Views/Account/Register.cshtml");
        }
    }
}