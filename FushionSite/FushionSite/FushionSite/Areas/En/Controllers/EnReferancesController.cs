using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionSiteEntityLibrary;

namespace FashionSite.Areas.En.Controllers
{
    [AllowAnonymous]
    public class EnReferancesController : Controller
    {
        //
        // GET: /Referances/
        private readonly FashionSiteContext _referancesContext;

        public EnReferancesController()
        {
            _referancesContext=new FashionSiteContext();
        }
        public ActionResult Index()
        {

            var comingServices = _referancesContext.Articles.Where(iL => iL.Language == "İngilizce").FirstOrDefault(rC => rC.ArticleCategory == "Referanslar");
            return View(comingServices);
        }

    }
}
