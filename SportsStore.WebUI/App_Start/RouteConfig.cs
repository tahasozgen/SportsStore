using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*
            public static Route MapRoute(this RouteCollection routes, string name, string url, object defaults);

            */
            routes.MapRoute(
                null,   //tstring name
                "", //string url
                new //object defaults
                {
                    controller = "Product",
                    action = "List",
                    category = (string)null,
                    page = 1
                }
            );

            /*
            public static Route MapRoute(this RouteCollection routes, string name, string url, object defaults, object constraints);
            */

            routes.MapRoute(null, //this RouteCollection routes            
                "Page{page}",   //string name            
                new { controller = "Product", action = "List",  //string url
                category = (string)null },// object defaults
                new { page = @"\d+" }   //object constraints
            );

            /*
            public static Route MapRoute(this RouteCollection routes, string name, string url, object defaults);
            */
            routes.MapRoute(
                null,               // string name
                "{category}",       //string url 
                new { controller = "Product", action = "List", page = 1 }   //object defaults
            );

            /*
            public static Route MapRoute(this RouteCollection routes, string name, string url, object defaults, object constraints);
            */
            routes.MapRoute(
                null,          //string name  
                "{category}/Page{page}",        //string url    
                new { controller = "Product", action = "List" },      //object defaults      
                new { page = @"\d+" }   // object constraints
            );

            routes.MapRoute(null, "{controller}/{action}");

        }
    }
}
