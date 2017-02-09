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
    public class ReferancesController : Controller
    {
        //
        // GET: /Referances/
        private readonly ComingData _comingData;

        public ReferancesController()
        {
            _comingData = new ComingData();
        }
        public ActionResult Index()
        {

            return View(_comingData.Articles("Türkçe", "Referanslar"));
        }

    }
}
