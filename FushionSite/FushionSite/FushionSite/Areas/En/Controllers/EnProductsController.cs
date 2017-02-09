using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionSiteEntityLibrary;

namespace FashionSite.Areas.En.Controllers
{
    [AllowAnonymous]
    public class EnProductsController : Controller
    {
        //
        // GET: /Products/
        private readonly FashionSiteContext _productContext;

        public EnProductsController()
        {
                _productContext=new FashionSiteContext();
        }
        public ActionResult Index()
        {
            var comingProduct =
                (from p in _productContext.Gallery select p).Where(pC => pC.Category == "Ürünler")
                    .OrderByDescending(pId => pId.GalleryId);
            ViewData["sendProduct"] = comingProduct;
            return View();
        }

    }
}
