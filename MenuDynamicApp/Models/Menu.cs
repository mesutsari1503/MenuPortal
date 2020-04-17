using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuDynamicApp.Models
{
    public class Menu
    {
        public Menu()
        {
            menuitem = new List<MenuIDetails>();
            menuitem.Add(new Models.MenuIDetails { Link = "/", Name = "Home" });
            menuitem.Add(new Models.MenuIDetails { Link = "/Account/Login", Name = "Login" });
            menuitem.Add(new Models.MenuIDetails { Link = "/Account/Registration", Name = "Register" });
            menuitem.Add(new Models.MenuIDetails { Link = "/Manage/Index", Name = "Manage" });
            menuitem.Add(new Models.MenuIDetails { Link = "/Manage/ManageLogin", Name = "Manage Logins" });
            menuitem.Add(new Models.MenuIDetails { Link = "/Home/Contact", Name = "Contact" });
            menuitem.Add(new Models.MenuIDetails { Link = "/Home/About", Name = "About" });
        }
        public List<MenuIDetails> menuitem { get; set; }
    }
}