using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyfirstApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
       public ActionResult Login(string UserName, string Password)
        {
            if (UserName == "Admin")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return RedirectToAction("InvalidLogin");
            }
        }

        public ActionResult InvalidLogin()
        {
            return View();
        }
    }
}