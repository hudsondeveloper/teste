using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace teste1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            Session["user"] = "Silvestre";
            ViewBag.Title="Repositorio";
            return View();
        }

        public ActionResult Flot()
        {
            return View();
        }
        public ActionResult Buttons()
        {
            return View();
        }

        public ActionResult Forms()
        {
            return View();
        }
        public ActionResult Grid()
        {
            return View();
        }
        public ActionResult Icons()
        {
            return View();
        }
        public ActionResult Morris()
        {
            return View();
        }
        public ActionResult Notifications()
        {
            return View();
        }
        public ActionResult Panel()
        {
            return View();
        }
        public ActionResult Tables()
        {
            return View();
        }
        public ActionResult Typography()
        {
            return View();
        }
        public ActionResult Readme()
        {
            return View();
        }
    }
}