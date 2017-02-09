using System.Web.Mvc;
using FushionSite.Models;

namespace FashionSite.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly ComingData _comingData;

        public HomeController()
        {
            _comingData = new ComingData();
        }

        public ActionResult Index()
        {
            ViewData["sendSlider"] = _comingData.HomeData("Türkçe");
            ViewData["sendProduct"] = _comingData.GalleryData("Ürünler", 0, 8);
            return View();
        }

    }
}
