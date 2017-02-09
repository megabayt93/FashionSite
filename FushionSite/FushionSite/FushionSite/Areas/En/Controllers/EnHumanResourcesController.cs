using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace FashionSite.Areas.En.Controllers
{
    [AllowAnonymous]
    public class EnHumanResourcesController : Controller
    {
        //
        // GET: /HumanReources/

        public ActionResult Index()
        {
            return View();
        }

        public JavaScriptResult SendHumanResources(string adsoyad, string tcnumarasi, string cins, string dogumyeri, string dogumtarihi_gun, string dogumtarihi_ay, string dogumtarihi_yil, string uyruk, string medenihali, string telefon, string email, string sehir, string evadres, string askerlik, string askerlikterhistarihi_gun, string askerlikterhistarihi_ay, string askerlikterhistarihi_yil, string mezun, string mezundal, string mezuntarihi, string mezuntarihi_ay, string mezuntarihi_yil, string oncekipozisyon, string mesaj, string mezuntarihi_gun)
        {
            try
            {
                SmtpClient SmtpServer = new SmtpClient("domainadi.com", 25);
                var sendMail = new MailMessage();
                sendMail.From = new MailAddress("iletisim@domainadi.com");

                sendMail.To.Add("iletisim@domainadi.com");



                sendMail.Subject = "İŞ BAŞVURUSU VAR";
                sendMail.IsBodyHtml = true;


                sendMail.Body = "<html><body><b>YENİ BİR İŞ BAŞVURUSU VAR!</b><br><br><b>Bilgiler Aşağıdaki Gibidir.</b><br><br>Başvuru Gönderenin<br> İsmi: " + adsoyad + " <br>e-Mail: " + email + "<br>TC Numarası: " + tcnumarasi + "<br>Cinsiyet: " + cins + "<br>Doğum Yeri: " + dogumyeri + "<br>Doğum Tarihi: " + dogumtarihi_gun + "/" + "/" + dogumtarihi_ay + "/" + dogumtarihi_yil + "<br>Uyruk: " + uyruk + "<br>Medeni Hali: " + medenihali + "<br>Telefon: " + medenihali + "<br>Telefon: " + telefon + "<br>Şehir Plaka Kodu: " + sehir + "<br>Adres: " + evadres + "<br>Askerlik: " + askerlik + "<br>Askerlik Terhis/Tecil Tarihi: " + askerlikterhistarihi_gun + "/" + askerlikterhistarihi_ay + "/" + askerlikterhistarihi_yil + "<br>Son Mezun Olduğu Okul: " + mezun + "<br>Mezun Olduğu Bölüm: " + mezundal + "<br>Mezuniyet Tarihi: " + mezuntarihi_gun + "/" + mezuntarihi_ay + "/" + mezuntarihi_yil + "<br>Önceki Pozisyon: " + oncekipozisyon + "<br>Mesaj: " + mesaj + "</body></html>";

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("iletisim@domainadi.com", "Mr52bk3~");

                SmtpServer.Send(sendMail);

                string s = "$('#Successfull').html('iş Başvurusu Başarıyla Gönderildi!'); setTimeout(function(){window.location='/home'},4000);";
                return JavaScript(s);
            }
            catch (Exception)
            {
                string s = "$('#Successfull').html('HATA! Mesajınız Gönderilemedi! Lütfen telefon ile iletişime geçiniz: +90 (344) 237 65 84'); setTimeout(function(){window.location='/iletisim'},4000);";
                return JavaScript(s);
            }
        }

    }
}
