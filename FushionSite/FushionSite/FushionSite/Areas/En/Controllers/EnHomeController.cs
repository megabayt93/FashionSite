using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionSiteEntityLibrary;

namespace FashionSite.Areas.En.Controllers
{
    [AllowAnonymous]
    public class EnHomeController : Controller
    {
        //
        // GET: /Home/
        private readonly FashionSiteContext FashionSiteContext;

        public EnHomeController()
        {
                FashionSiteContext=new FashionSiteContext();
        }

        public ActionResult Index()
        {
            var comingSlider =
                (from p in FashionSiteContext.HeadLine select p).Where(iL => iL.Language == "İngilizce").Where(sC => sC.HeadLineCategory == "Anasayfa Slider");

            var comingProduct =
              (from p in FashionSiteContext.Gallery select p).Where(sC => sC.Category == "Ürünler").OrderBy(pId=>pId.GalleryId).Skip(0).Take(8);
            ViewData["sendSlider"] = comingSlider;
            ViewData["sendProduct"] = comingProduct;
            return View();
        }

    }
}
