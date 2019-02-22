using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DirectorController : Controller
    {
        MovieDbContext db = new MovieDbContext();
        // GET: Director
        public ActionResult Index(/*int? id*/)
        {

            //return View(db.Director.Find(id));
            return View(db.Director.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="Name,Sex,Address")] Director director)
        {
            if(ModelState.IsValid)
            {
                db.Director.Add(director);
                db.SaveChanges();
               return RedirectToAction("index");
            }
            return View(director);
        }
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Director director=db.Director.Find(id);
            if(director==null)
            {
                return HttpNotFound();
            }
            return View(director);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            Director director = db.Director.Find(id);
            db.Director.Remove(director);
            db.SaveChanges();
            return RedirectToAction("index");
        }

    }
}