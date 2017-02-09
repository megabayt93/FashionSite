using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using FushionSite.Models;

namespace FashionSite.Areas.En.Controllers
{
    [AllowAnonymous]
    public class EnContactsController : Controller
    {
        //
        // GET: /Contacts/
        private readonly ComingData _comingData;
        private readonly Mail _mail = new Mail();
        public EnContactsController()
        {
            _comingData = new ComingData();
        }
        public ActionResult Index()
        {
            return View(_comingData.Contact("Türkçe"));
        }

        public JavaScriptResult Send(string adsoyad, string email, string konu, string mesaj)
        {

            return JavaScript(_mail.MailSendResult(adsoyad, email, konu, mesaj));
        }


    }
}

