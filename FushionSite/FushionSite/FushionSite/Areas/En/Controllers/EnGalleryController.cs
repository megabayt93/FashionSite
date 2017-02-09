using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionSiteEntityLibrary;

namespace FashionSite.Areas.En.Controllers
{
    [AllowAnonymous]
    public class EnGalleryController : Controller
    {
        //
        // GET: /Gallery/
        private readonly FashionSiteContext galleryContext;

        public EnGalleryController()
        {
                galleryContext=new FashionSiteContext();
        }
        public ActionResult Index()
        {
            var comingGallery = (from p in galleryContext.Gallery select p).OrderByDescending(gId => gId.GalleryId);
            ViewData["sendGallery"] = comingGallery;
            return View();
        }

        public ActionResult Factory()
        {
            var comingGallery = (from p in galleryContext.Gallery select p).Where(gC=>gC.Category=="Fabrika").OrderByDescending(gId => gId.GalleryId);
            ViewData["sendGallery"] = comingGallery;
            return View();
        }

        public ActionResult Production()
        {
            var comingGallery = (from p in galleryContext.Gallery select p).Where(gC => gC.Category == "Ürünler").OrderByDescending(gId => gId.GalleryId);
            ViewData["sendGallery"] = comingGallery;
            return View();
        }

    }
}
