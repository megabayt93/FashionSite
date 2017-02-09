using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionSiteEntityLibrary;
using FushionSite.Models;

namespace FashionSite.Controllers
{
    [AllowAnonymous]
    public class GalleryController : Controller
    {
        //
        // GET: /Gallery/
        private readonly ComingData _comingData;

        public GalleryController()
        {
               _comingData=new ComingData();
        }
        public ActionResult Index()
        {

            ViewData["sendGallery"] = _comingData.GalleryData("Ürünler",0,0);
            return View();
        }

        public ActionResult Factory()
        {
            ViewData["sendGallery"] = _comingData.GalleryData("Fabrika", 0, 0);
            return View();
        }

        public ActionResult Production()
        {
            ViewData["sendGallery"] = _comingData.GalleryData("Ürünler", 0, 0);
            return View();
        }

    }
}
