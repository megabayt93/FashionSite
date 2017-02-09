using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionSiteEntityLibrary;

namespace FashionSite.Areas.En.Controllers
{
    [AllowAnonymous]
    public class EnInstitutionalController : Controller
    {
        //
        // GET: /Institutional/
        private readonly FashionSiteContext _institutionalContext;

        public EnInstitutionalController()
        {
            _institutionalContext=new FashionSiteContext();
        }
        public ActionResult Index()
        {
            var comingAbout = _institutionalContext.Articles.Where(iL => iL.Language == "İngilizce").FirstOrDefault(iId => iId.ArticleCategory == "Hakkımızda");
            return View(comingAbout);
        }

        public ActionResult Vision()
        {
            var comingAbout = _institutionalContext.Articles.Where(iL => iL.Language == "İngilizce").FirstOrDefault(iId => iId.ArticleCategory == "Vizyonumuz");
            return View(comingAbout);
        }

        public ActionResult Mission()
        {
            var comingAbout = _institutionalContext.Articles.Where(iL => iL.Language == "İngilizce").FirstOrDefault(iId => iId.ArticleCategory == "Misyonumuz");
            return View(comingAbout);
        }

    }
}
