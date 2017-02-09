using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionSiteEntityLibrary;

namespace FashionSite.Areas.En.Controllers
{
    [AllowAnonymous]
    public class EnServicesController : Controller
    {
        //
        // GET: /Services/
        private readonly FashionSiteContext _servicesContext;

        public EnServicesController()
        {
            _servicesContext=new FashionSiteContext();
        }
        public ActionResult Index()
        {
            var comingServices = _servicesContext.Articles.Where(iL => iL.Language == "İngilizce").FirstOrDefault(sC => sC.ArticleCategory == "Hizmetler");
            return View(comingServices);
        }

    }
}
