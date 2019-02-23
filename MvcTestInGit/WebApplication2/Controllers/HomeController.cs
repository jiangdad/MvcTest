using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        MovieDbContext db = new MovieDbContext();
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
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
         
            return View("Index2", user);
        }
    }
}