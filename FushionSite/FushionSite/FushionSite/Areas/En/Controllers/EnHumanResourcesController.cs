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
    public class EnHumanResourcesController : Controller
    {
        //
        // GET: /HumanReources/
        private readonly Mail _mail = new Mail();
        public ActionResult Index()
        {
            return View();
        }

        public JavaScriptResult SendHumanResources(string adsoyad, string tcnumarasi, string cins, string dogumyeri, string dogumtarihi_gun, string dogumtarihi_ay, string dogumtarihi_yil, string uyruk, string medenihali, string telefon, string email, string sehir, string evadres, string askerlik, string askerlikterhistarihi_gun, string askerlikterhistarihi_ay, string askerlikterhistarihi_yil, string mezun, string mezundal, string mezuntarihi, string mezuntarihi_ay, string mezuntarihi_yil, string oncekipozisyon, string mesaj, string mezuntarihi_gun)
        {

            return JavaScript(_mail.MailSendResult(adsoyad, tcnumarasi, cins, dogumyeri, dogumtarihi_gun, dogumtarihi_ay, dogumtarihi_yil, uyruk, medenihali, telefon, email, sehir, evadres, askerlik, askerlikterhistarihi_gun, askerlikterhistarihi_ay, askerlikterhistarihi_yil, mezun, mezundal, mezuntarihi, mezuntarihi_ay, mezuntarihi_yil, oncekipozisyon, mesaj, mezuntarihi_gun));
        }

    }
}
