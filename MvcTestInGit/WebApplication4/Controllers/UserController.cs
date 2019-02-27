using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tgnet.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.Models.Test;
using DIary.Data;
using Diary.Service.User;
using Tgnet;

namespace WebApplication4.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public IUserManager _IUserManager;
        public UserController(IUserManager _IuserManager)
        {
            _IUserManager = _IuserManager;
        }
        UserDiaryDb db = new UserDiaryDb();
        DiaryEntities DB = new DiaryEntities();
        public ActionResult Index()
        {
            
            return View();
        }
        
      
        //public ActionResult Login()
        //{ 
            
        //    //var user = db.User.ToArray();
        //    return View();
        //}
        [DisplayName("Login2")]
        [HttpPost]
     public ActionResult Login([Bind(Include = "userName,passWord")]Users user)
        {
            //var user2 = db.User.FirstOrDefault(model => model.UserName == user.UserName);
            //var diaries = new List<Diary>();
            //var userid = db.User.FirstOrDefault(model => model.UserName == user.UserName).Id;


            //var item = db.User.FirstOrDefault(model => model.Password == user.Password && model.UserName == user.UserName);
            ////var user = db.User.ToArray();
            //if(item!=null)
            //{
            // //diaries = db.User;
            // return View("UserIndex",diaries);
            //}
            //return View("login");
            if (User != null)//已经登陆了，跳转首页
                return RedirectToAction("Index", "Home");
            else
                return JsonString(new UserLoginModel() { Status = "error", Msg = "请输入用户名或密码" });
            user.landIp = Request.GetCurrentIP();
            user.lastLandTime = DateTime.Now;
            var model = _IUserManager.Login(user);

        }
        public ActionResult Login()
        {
            if (Request.IsAjaxRequest())
            {
               UserLoginModel model = new UserLoginModel() { Status = "error" };
                int userId = User == null ? -1 : User.ID.To<int>();
                if (userId > 0)
                {
                    var userService = _IUserManager.GetService(userId);
                    if (userService != null)
                    {
                        model.Status = "ok";
                        model.Msg = "登陆成功";
                        model.UserName = userService.UserName;
                        model.UserId = userService.UserId;
                    }
                    else
                    {
                        model.Msg = "不存在该用户";
                    }
                }
                return JsonString(model);
            }
            else
            {
                if (User != null)
                    return RedirectToAction("Index", "Home");
                return View();
            }
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