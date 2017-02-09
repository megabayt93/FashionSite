using FashionSiteEntityLibrary;
using System.Linq;
using System.Web.Mvc;
using FushionSite.Models;

namespace FashionSite.Controllers
{
    [AllowAnonymous]
    public class ServicesController : Controller
    {
        //
        // GET: /Services/
        private readonly ComingData _comingData;

        public ServicesController()
        {
            _comingData = new ComingData();
        }
        public ActionResult Index()
        {

            return View(_comingData.Articles("Türkçe", "Hizmetler"));
        }

    }
}
