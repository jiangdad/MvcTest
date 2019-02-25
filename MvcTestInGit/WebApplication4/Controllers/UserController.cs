using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.Models.Test;

namespace WebApplication4.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserDiaryDb db = new UserDiaryDb();
        DiaryEntities DB = new DiaryEntities();
        public ActionResult Index()
        {
            
            return View();
        }
        
      
        public ActionResult Login()
        { 
            
            //var user = db.User.ToArray();
            return View();
        }
        [DisplayName("Login")]
        [HttpPost]
     public ActionResult Login(Models.User user)
        {
            //var user2 = db.User.FirstOrDefault(model => model.UserName == user.UserName);
            var diaries = new List<Diary>();
            var userid = db.User.FirstOrDefault(model => model.UserName == user.UserName).Id;
            
            diaries = db.User.diaries.Where(d => d.UserId == userid).ToList();
            var item = db.User.FirstOrDefault(model => model.Password == user.Password && model.UserName == user.UserName);
            //var user = db.User.ToArray();
            if(item!=null)
            {
             return View("UserIndex",diaries);
            }
            return View("login");
          
        }
        public ActionResult Register()
        {
            
            return View();
        }
        [DisplayName("Register")]
        [HttpPost]
  public ActionResult Register(Models.User user)
        {
            if(db.User.FirstOrDefault(model=>model.UserName==user.UserName)!=null)
            {
                ModelState.AddModelError("", "用户名重复");
                return View(user);
            }
            db.User.Add(user);
            db.SaveChanges();
            return View("Login");
        }
    }
}