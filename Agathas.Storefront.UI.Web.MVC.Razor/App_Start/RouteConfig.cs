using System.Web.Mvc;
using System.Web.Routing;

namespace Agathas.Storefront.UI.Web.MVC.Razor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

            routes.MapRoute(
                "ProductDetail",                                                // Route name
                "Product/{brand}-{productname}/{id}",                          // URL with parameters
                new { controller = "Product", action = "Detail", id = "" } // Parameter defaults
            );

            routes.MapRoute(
                "Browse",                                                // Route name
                "Category/{category}/{categoryId}",                                  // URL with parameters
                new { controller = "Product", action = "GetProductsByCategory", id = "" } // Parameter defaults
            );

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }  // Parameter defaults
            );

        }
    }
}
