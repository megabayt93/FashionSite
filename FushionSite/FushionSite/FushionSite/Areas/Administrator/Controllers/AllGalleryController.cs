using FashionSite.Areas.Administrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using FashionSiteEntityLibrary;

namespace FashionSite.Areas.Administrator.Controllers
{
    public class AllGalleryController : Controller
    {
        //
        // GET: /Administrator/AllGallery/
      private  readonly FashionSiteContext _galleriesContext;
      private  readonly ModelGallery _modelGallery;
        public AllGalleryController()
        {
            _modelGallery = new ModelGallery();
            _galleriesContext = new FashionSiteContext();
        }
        public ActionResult Index(int page = 1)
        {
            var comingGalleries = _galleriesContext.Gallery.OrderBy(gId => gId.GalleryId > 0).ToPagedList(page,20);
            ViewBag.SendGalleries = comingGalleries;
            Session["page"] = page;
            var comingCategories = _galleriesContext.Categories.OrderBy(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;

            return View();
        }

        public ActionResult Delete(int id)
        {
            _modelGallery.Delete(id);
            string uri = Session["uri"].ToString();
            return Redirect(uri);
        }

    }
}
