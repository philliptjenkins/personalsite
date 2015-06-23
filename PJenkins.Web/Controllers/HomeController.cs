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
            @ViewBag.Title = "Phillip Jenkins - Home";
            return View();
        }

        public ActionResult About()
        {
            @ViewBag.Title = "Phillip Jenkins - About";
            return View();
        }

        public ActionResult Contact()
        {
            @ViewBag.Title = "Phillip Jenkins - Contact";
            return View();
        }

        public ActionResult Resume()
        {
            @ViewBag.Title = "Phillip Jenkins - Resume";
            return View();
        }

        public ActionResult Portfolio()
        {
            //fanciness to load different project pages
            @ViewBag.Title = "Phillip Jenkins - Portfolio";
            return View();
        }
    }
}