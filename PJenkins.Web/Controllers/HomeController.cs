using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PJenkins.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            @ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult About()
        {
            @ViewBag.Title = "About Me";
            return View();
        }

        public ActionResult Contact()
        {
            @ViewBag.Title = "Contact Info";
            return View();
        }

        public ActionResult Resume()
        {
            @ViewBag.Title = "My Resume";
            return View();
        }

        public ActionResult Portfolio()
        {
            //fanciness to load different project pages
            @ViewBag.Title = "My Portfolio";
            return View();
        }
    }
}