using System.Linq;
using System.Web.Mvc;
using FashionSiteEntityLibrary;
using FushionSite.Models;

namespace FashionSite.Controllers
{
    [AllowAnonymous]
    public class InstitutionalController : Controller
    {
        //
        // GET: /Institutional/
        private readonly ComingData _comingData;

        public InstitutionalController()
        {
            _comingData = new ComingData();
        }
        public ActionResult Index()
        {

            return View(_comingData.Articles("Türkçe", "Hakkımızda"));
        }

        public ActionResult Vision()
        {
            return View(_comingData.Articles("Türkçe", "Vizyonumuz"));
        }

        public ActionResult Mission()
        {
            return View(_comingData.Articles("Türkçe", "Misyonumuz"));
        }

    }
}
