using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace FushionSite.Models
{
    public class Mail
    {


        public string MailSendResult(string adsoyad, string email, string konu, string mesaj)
        {
            SmtpClient smtpServerClient = new SmtpClient("domain adı", 25);
            var sendMail = new MailMessage();
            try
            {
                sendMail.From = new MailAddress("iletisim@domainadi.com");
                sendMail.To.Add("iletisim@domainadi.comm");
                sendMail.Subject = "MESAJINIZ VAR";
                sendMail.IsBodyHtml = true;


                sendMail.Body = "<html><body><b>YENİ BİR MESAJ VAR!</b><br><br><b>Bilgiler Aşağıdaki Gibidir.</b><br><br>Mesaj Gönderenin<br> İsmi: " + adsoyad + " <br>e-Mail: " + email + "<br>Konu: " + konu + "<br>Mesaj: " + mesaj + "</body></html>";
                smtpServerClient.UseDefaultCredentials = false;
                smtpServerClient.Credentials = new System.Net.NetworkCredential("iletisim@domainadi.com", "Parola");
                smtpServerClient.Send(sendMail);

                string exec =
                    "$('#info').html('Mesajınız Başarıyla Gönderildi! İletişime Geçeceğiz.'); setTimeout(function(){window.location='/home'},3000);";
                return exec;
            }
            catch (Exception)
            {
                string exec =
                    "$('#info').html('HATA! Mesajınız Gönderilemedi!'); setTimeout(function(){window.location='/iletisim'},3000);";
                return exec;
            }

        }

        public string MailSendResult(string adsoyad, string tcnumarasi, string cins, string dogumyeri, string dogumtarihi_gun, string dogumtarihi_ay, string dogumtarihi_yil, string uyruk, string medenihali, string telefon, string email, string sehir, string evadres, string askerlik, string askerlikterhistarihi_gun, string askerlikterhistarihi_ay, string askerlikterhistarihi_yil, string mezun, string mezundal, string mezuntarihi, string mezuntarihi_ay, string mezuntarihi_yil, string oncekipozisyon, string mesaj, string mezuntarihi_gun)
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
                SmtpServer.Credentials = new System.Net.NetworkCredential("iletisim@domainadi.com", "parola");

                SmtpServer.Send(sendMail);

                string humanResources = "$('#Successfull').html('iş Başvurusu Başarıyla Gönderildi!'); setTimeout(function(){window.location='/home'},4000);";
                return humanResources;
            }
            catch (Exception)
            {
                string humanResources = "$('#Successfull').html('HATA! Mesajınız Gönderilemedi! Lütfen telefon ile iletişime geçiniz: +90 (344) 000 00 00'); setTimeout(function(){window.location='/iletisim'},4000);";
                return humanResources;
            }
        }
    }
}