using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FashionSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "anasayfa",
                defaults: new {controller = "Home", action = "Index", id = "0"}
                );

            routes.MapRoute(
              name: "Contacts",
              url: "iletisim",
              defaults: new { controller = "Contacts", action = "Index", id = "0" }
              );
            routes.MapRoute(
         name: "ContactsSend",
         url: "send",
         defaults: new { controller = "Contacts", action = "Send", id = UrlParameter.Optional }
     );
            routes.MapRoute(
             name: "Gallery",
             url: "galeri",
             defaults: new { controller = "Gallery", action = "Index", id = "0" }
             );


          

            routes.MapRoute(
             name: "Factory",
             url: "fabrika",
             defaults: new { controller = "Gallery", action = "Factory", id = "0" }
             );
            routes.MapRoute(
           name: "HumanResources",
           url: "insan-kaynaklari",
           defaults: new { controller = "HumanResources", action = "Index", id = "0" }
           );

            routes.MapRoute(
            name: "Production",
            url: "uretim",
            defaults: new { controller = "Gallery", action = "Production", id = "0" }
            );





            routes.MapRoute(
            name: "Institutional",
            url: "kurumsal",
            defaults: new { controller = "Institutional", action = "Index", id = "0" }
            );

         


            routes.MapRoute(
            name: "Vision",
            url: "vizyon",
            defaults: new { controller = "Institutional", action = "Vision", id = "0" }
            );


            routes.MapRoute(
            name: "Mission",
            url: "misyon",
            defaults: new { controller = "Institutional", action = "Mission", id = "0" }
            );



            routes.MapRoute(
           name: "Products",
           url: "urunler",
           defaults: new { controller = "Products", action = "Index", id = "0" }
           );

            routes.MapRoute(
           name: "Referances",
           url: "referanslar",
           defaults: new { controller = "Referances", action = "Index", id = "0" }
           );

            routes.MapRoute(
          name: "Services",
          url: "Hizmetler",
          defaults: new { controller = "Services", action = "Index", id = "0" }
          );
            routes.MapRoute(
  "404-PageNotFound",
  "{*url}",
  new { controller = "Home", action = "Index" }
  );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}