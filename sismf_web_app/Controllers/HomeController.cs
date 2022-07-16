using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sismf_web_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page."; //Optional Message

            return View();
        }

        //Optional Method
        public ActionResult Contact() 
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}