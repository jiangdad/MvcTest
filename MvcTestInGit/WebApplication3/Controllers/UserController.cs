using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.LoginModel loginmodel)
        {
            if (loginmodel.UserName == "蒋国涛" && loginmodel.Password == "123456") 
            Response.Write("正确");
            else
            Response.Write("错误");
            return View();
        }
    }
}