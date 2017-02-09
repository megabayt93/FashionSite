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


    }
}