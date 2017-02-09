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
    public class ProductsController : Controller
    {
        //
        // GET: /Products/
        private readonly ComingData _comingData;

        public ProductsController()
        {
            _comingData = new ComingData();
        }
        public ActionResult Index()
        {

            ViewData["sendProduct"] = _comingData.GalleryData("Ürünler", 0, 0);
            return View();
        }

    }
}
