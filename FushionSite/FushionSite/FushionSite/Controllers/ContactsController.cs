using System.Web.Mvc;
using FushionSite.Models;

namespace FashionSite.Controllers
{
    [AllowAnonymous]
    public class ContactsController : Controller
    {
        //
        // GET: /Contacts/


        private readonly ComingData _comingData;

        public ContactsController()
        {
            _comingData = new ComingData();
        }

        public ActionResult Index()
        {
            return View(_comingData.Contact("Türkçe"));
        }

        private readonly Mail _mail = new Mail();

        public JavaScriptResult Send(string adsoyad, string email, string konu, string mesaj)
        {

            return JavaScript(_mail.MailSendResult(adsoyad, email, konu, mesaj));

        }

    }
}