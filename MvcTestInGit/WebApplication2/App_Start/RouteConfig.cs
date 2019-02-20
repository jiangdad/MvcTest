using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //对所有axd的资源 进行忽略，直接进行URL访问,{*pathInfo} 表示所有路径
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //{ resource}.axd 表示后缀名为.axd所有资源 如webresource.axd
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
