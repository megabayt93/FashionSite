using FashionSite.Areas.Administrator.Models;
using FashionSiteEntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionSiteEntityLibrary.ContactEntity;

namespace FashionSite.Areas.Administrator.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Administrator/Contact/
       private readonly FashionSiteContext _contactContext;
       private readonly ModelUser _modelUser;
        public ContactController()
        {
            _modelUser = new ModelUser();
            _contactContext = new FashionSiteContext();
        }
        public ActionResult Index()
        {
            var comingContact = _contactContext.Contacts.FirstOrDefault(cId => cId.ContactId > 0);
            
            return View(comingContact);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [HttpPost, ValidateInput(false)]
        public JavaScriptResult UpdateContact(ContactsTable contactTable)
        {
           
                _modelUser.ContactUpdate(contactTable.ContactContent);

                string rtrn = "$('#divInformation').html('<img src=/Areas/Administrator/Images/ajax-loader.gif class=loaderGif></img>'); window.location='/administrator/contact'";
                return JavaScript(rtrn);
           

        }

    }
}
