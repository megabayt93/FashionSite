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
    public class AllMediaController : Controller
    {
        //
        // GET: /Administrator/AllMedia/
      private readonly FashionSiteContext _mediaContext;
       private readonly ModelMedia _modelMedia;
        public AllMediaController()
        {
            _mediaContext = new FashionSiteContext();
            _modelMedia = new ModelMedia();
        }
        public ActionResult Index(int page = 1)
        {
            var comingMedias = _mediaContext.Medias.OrderBy(mId => mId.MediaId > 0).ToPagedList(page, 20);
            ViewBag.SendMedias = comingMedias;
            Session["page"] = page;
            return View();
        }

        public ActionResult Delete(int id)
        {
            _modelMedia.Delete(id);
            string uri = Session["uri"].ToString();
            return Redirect(uri);
        }

    }
}
