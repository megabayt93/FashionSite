using FashionSite.Areas.Administrator.Models;
using FashionSiteEntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FashionSite.Areas.Administrator.Controllers
{
    public class UserSettingsController : Controller
    {
        //
        // GET: /Administrator/UserSettings/
       private readonly ModelUser _control;
       private readonly FashionSiteContext _adminContext;
        public UserSettingsController()
        {
            _control = new ModelUser();
            _adminContext = new FashionSiteContext();
        }


        public ActionResult Index()
        {
            var updateAdm = _adminContext.Admin.FirstOrDefault(aID => aID.AdminId > 0);
            return View(updateAdm);
        }

        public JavaScriptResult Update(string adminName, string oldPassword, string newPassword)
        {

            if ( newPassword!="" && _control.UpdateAdmin(adminName, oldPassword, newPassword) == true)
            {
                string script = "$('#divInformation').html('Bilgiler Güncellendi');";
                return JavaScript(script);
            }
            else
            {
                string script = "$('#divInformation').html('Hata!');";
                return JavaScript(script);
            }

        }



    }
}
