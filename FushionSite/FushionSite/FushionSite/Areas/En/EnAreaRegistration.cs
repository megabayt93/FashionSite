using System.Web.Mvc;

namespace FashionSite.Areas.En.Controllers
{
    public class EnAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "En";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: "EnGalleryFactory//{title}",
                url: "En/factory",
                defaults: new { controller = "EnGallery", action = "Factory", UrlParameter.Optional }
                );

            context.MapRoute(
               name: "EnGalleryProduction//{title}",
               url: "En/production",
               defaults: new { controller = "EnGallery", action = "Production", UrlParameter.Optional }
               );


            context.MapRoute(
                name: "EnInstitutionalMission//{title}",
                url: "En/mission",
                defaults: new { controller = "EnInstitutional", action = "Mission", UrlParameter.Optional }
                );

            context.MapRoute(
            name: "EnInstitutionalVision//{title}",
            url: "En/vision",
            defaults: new { controller = "EnInstitutional", action = "Vision", UrlParameter.Optional }
            );

            context.MapRoute(
    name: "EnReferances//{title}",
    url: "En/referances",
    defaults: new { controller = "EnReferances", action = "Index", UrlParameter.Optional }
    );


            context.MapRoute(
    name: "EnServices//{title}",
    url: "En/services",
    defaults: new { controller = "EnServices", action = "Index", UrlParameter.Optional }
    );
            context.MapRoute(
   name: "EnContacts//{title}",
   url: "En/contacts",
   defaults: new { controller = "EnContacts", action = "Index", UrlParameter.Optional }
   );
            context.MapRoute(
   name: "EnGallery//{title}",
   url: "En/gallery",
   defaults: new { controller = "EnGallery", action = "Index", UrlParameter.Optional }
   );
            context.MapRoute(
   name: "EnHome//{title}",
   url: "En/home",
   defaults: new { controller = "EnHome", action = "Index", UrlParameter.Optional }
   );
            context.MapRoute(
   name: "EnHumanResources//{title}",
   url: "En/human-resources",
   defaults: new { controller = "EnHumanResources", action = "Index", UrlParameter.Optional }
   );
            context.MapRoute(
   name: "EnInstitutional//{title}",
   url: "En/institutional",
   defaults: new { controller = "EnInstitutional", action = "Index", UrlParameter.Optional }
   );
            context.MapRoute(
   name: "EnProducts//{title}",
   url: "En/Products",
   defaults: new { controller = "EnProducts", action = "Index", UrlParameter.Optional }
   );
            context.MapRoute(
                "En_default",
                "En/{controller}/{action}/{id}",
                new { controller = "EnHome", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
