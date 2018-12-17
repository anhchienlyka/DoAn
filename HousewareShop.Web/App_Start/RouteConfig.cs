using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HousewareShop.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "Search",
           url: "tim-kiem",
            defaults: new { controller = "Product", action = "Search", id = UrlParameter.Optional },
             namespaces: new string[] { "HousewareShop.Web.Controllers" }
            );
            routes.MapRoute(
         name: "Login",
         url: "dang-nhap.html",
         defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
         namespaces: new string[] { "HousewareShop.Web.Controllers" }
     );
            routes.MapRoute(
           name: "About",
           url: "gioi-thieu.html",
           defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
           namespaces: new string[] { "HousewareShop.Web.Controllers" }
       );
            routes.MapRoute(
             name: "Product_Category",
                 // url: "sanpham/{Id}",
                 url: "{alias}-{categoryId}",
             defaults: new { controller = "Product", action = "Category", categoryId = UrlParameter.Optional },
               namespaces: new string[] { "HousewareShop.Web.Controllers" }
         );
            routes.MapRoute(
             name: "Product",
            //url: "sanpham-chitiet/{productId}",
            url: "{alias}/{aliasProduct}-{productId}",
            // url: "{alias}.p-{productId}.html",
             defaults: new { controller = "Product", action = "Detail", productId = UrlParameter.Optional },
               namespaces: new string[] { "HousewareShop.Web.Controllers" }
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                  namespaces: new string[] { "HousewareShop.Web.Controllers" }
            );

        }
    }
}
