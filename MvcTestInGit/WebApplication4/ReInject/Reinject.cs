using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tgnet.Web.Mvc.Inject;

namespace WebApplication4.ReInject
{
    public class Reinject
    {
        public static void Reinjected() {
            var modules = new Ninject.Modules.NinjectModule[] {
                  new  Diary.Service.inject.DataInject (),
                new Diary.Service.inject.ServiceInject()
            };
            var ninjectDependencyResolver = new NinjectDependencyResolver(modules);
            //DependencyResolver.SetResolver(ninjectDependencyResolver);
            System.Web.Mvc.DependencyResolver.SetResolver(ninjectDependencyResolver);
        }
    }
}