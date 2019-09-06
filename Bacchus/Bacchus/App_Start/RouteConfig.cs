using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bacchus
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");           

            routes.MapRoute(
                    name: "Default1",
                    url: "Auction/{productID}", // Kasutame productID parameetrina
                    defaults: new { controller = "Auction", action = "AuctionDetail" } // Default Controller & Action
                );

            routes.MapRoute(
                name: "Default2",
                url: "Auction/Auction",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
