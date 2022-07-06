using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GetStartedWithASPNETMVC
{
    public class RouteConfig
    {
        /// <summary>
        /// 路由规则的申明
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "AlbertDate",
               url: "{controller}/{action}_{year}_{month}_{day}/{id}",
               defaults: new { controller = "Home", action = "AlbertDate", id = UrlParameter.Optional },
               constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
