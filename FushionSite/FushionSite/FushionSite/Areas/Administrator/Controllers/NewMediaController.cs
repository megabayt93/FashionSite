using FashionSite.Areas.Administrator.Models;
using FashionSiteEntityLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FashionSite.Areas.Administrator.Controllers
{
    public class NewMediaController : Controller
    {
        //
        // GET: /Administrator/NewMedia/
      
      private  readonly ModelMedia _modelMedia;
        public NewMediaController()
        {
            _modelMedia = new ModelMedia();
           
        }
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [HttpPost, ValidateInput(false)]
        public ActionResult Add(IEnumerable<HttpPostedFileBase> files)
        {
            if (files != null)
            {
               
                    foreach (var file in files)
                    {
                        var path = Path.Combine(Server.MapPath("~/Content/Images/Media/"), file.FileName.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-"));
                        _modelMedia.Add(file.FileName.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-"));
                        file.SaveAs(path);
                    }

                    return RedirectToAction("index", "allmedia");
                
   
            }
            else
            {
                return RedirectToAction("index", "allmedia");
            }
           
        }

    }
}
