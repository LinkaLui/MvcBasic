using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcBasic_Clone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MacRoute",
                url: "MyMac",
                defaults: new { controller = "Mac", action = "MacPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "iPadRoute",
                url: "MyiPad",
                defaults: new { controller = "iPad", action = "iPadPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "iPhoneRoute",
                url: "MyiPhone",
                defaults: new { controller = "iPhone", action = "iPhonePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "WatchRoute",
                url: "MyWatch",
                defaults: new { controller = "Watch", action = "WatchPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EmployeesRoute",
                url: "MyEmployees",
                defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "FriendsRoute",
                url: "MyFriends",
                defaults: new { controller = "Friends", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
