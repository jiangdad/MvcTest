using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DirectorController : Controller
    {
        // GET: Director
        public ActionResult Index(int id)
        {
            MovieDbContext db = new MovieDbContext();
            return View(db.Director.Find(id));
        }
    }
}