using FashionSite.Model;
using FashionSiteEntityLibrary.AdminInformationEntity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FashionSite.Areas.Administrator.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        //
        // GET: /Administrator/Login/
        private readonly LoginCore _loginCore;

        public LoginController()
        {
                _loginCore=new LoginCore();
        }
        public ActionResult Index()
        {
            return View();
        }

        public JavaScriptResult Control(AdminInformationTable adminInformation)
        {
            _loginCore.Log(adminInformation.AdminName, adminInformation.AdminPassword);
            if (_loginCore.Status == true)
            {
                const int userId = 1;
                const string role = "Admin";
                string userData = userId.ToString(CultureInfo.InvariantCulture) + "," + adminInformation.AdminName.Trim() + "," + role;
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
             1,
             adminInformation.AdminName,
             DateTime.Now,
             DateTime.Now.AddMinutes(120),
             false,
             userData,
             FormsAuthentication.FormsCookiePath);

                string encryptedTicket = FormsAuthentication.Encrypt(ticket);

                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);
                string s = "$('#divError').html('<img src=/Areas/Administrator/Images/ajax-loader.gif class=loaderGif></img>'); window.location='/administrator/newarticles'";
                return JavaScript(s);


            }
            else
            {

                string rtrn = "$('#divError').html('Hatalı Kullanıcı Adı veya şifre');";
                return JavaScript(rtrn);
            }
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            return new RedirectResult("/anasayfa");
        }

    }
}
