using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HelloWorld(string name,int numtime)
        {
            ViewBag.NumTime = numtime;
            ViewBag.Message = "welcome" + name;
            return View();
        }

        public string Welcome(string name,int ID=1)
        {
            return HttpUtility.HtmlEncode(name + ID);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}