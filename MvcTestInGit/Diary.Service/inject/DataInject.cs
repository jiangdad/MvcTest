using DIary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diary.Service.inject
{
    public class DataInject : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IUserRepository>().ToSelf();
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}