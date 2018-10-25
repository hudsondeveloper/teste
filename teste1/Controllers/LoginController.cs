using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace teste1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logar(string email, string password)
        {

            if(email =="silvestre" || email == "Silvestre" && password == "silvestre" | password == "Silvestre")
            {
                return RedirectToAction("Index","Home");
            }
            return RedirectToAction("Index", "Login");
        }
    }
}