using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MenuDynamicApp.Models;

namespace MenuDynamicApp.Controllers
{
    public class ManageController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Manage/Index.cshtml");
        }
        public ActionResult ManageLogin()
        {
            return View("~/Views/Account/Login.cshtml");
        }
     
    }
}