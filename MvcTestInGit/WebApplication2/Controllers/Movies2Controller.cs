using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class Movies2Controller : Controller
    {
        // GET: Movies2
        private MovieDbContext db = new MovieDbContext();
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }
    }
}