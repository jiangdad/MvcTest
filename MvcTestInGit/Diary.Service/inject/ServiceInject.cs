using Diary.Service.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diary.Service.inject
{
    public class ServiceInject: Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IUserManager>().To<UserManager>();
            Bind<IUserService>().To<UserService>();
        }

       
    }
}