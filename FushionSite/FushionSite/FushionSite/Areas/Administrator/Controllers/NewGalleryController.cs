
using FashionSite.Areas.Administrator.Models;
using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.GalleryEntiy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FashionSite.Areas.Administrator.Controllers
{
    public class NewGalleryController : Controller
    {
        //
        // GET: /Administrator/NewGallery/
      private  readonly FashionSiteContext _galleriesContext;
       
       private readonly ModelGallery _modelGallery;
        public NewGalleryController()
        {
            _modelGallery = new ModelGallery();
            _galleriesContext = new FashionSiteContext();
          
        }
        public ActionResult Index()
        {
            var comingCategories = _galleriesContext.Categories.Where(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [HttpPost, ValidateInput(false)]
        public virtual ActionResult Add(IEnumerable<HttpPostedFileBase> files, GalleryTable galleriesTable, string category)
        {

            if (files != null)
            {
                if (category != null)
                {
                    foreach (var file in files)
                    {
                        var path = Path.Combine(Server.MapPath("~/Content/Images/Gallery/"), galleriesTable.Category.Replace(' ','-')+file.FileName.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-"));
                        _modelGallery.Add(galleriesTable.Category.Replace(' ', '-') + file.FileName.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-"), category);
                        file.SaveAs(path);
                    }

                    return RedirectToAction("index", "allgallery");
                }
                else
                {
                    return RedirectToAction("index", "newgallery");


                }
                

            }
            else
            {

                return RedirectToAction("index", "newgallery");
            }
           
           

        }

    }
}
