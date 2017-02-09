using FashionSite.Areas.Administrator.Models;
using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.HeadLineEntity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FashionSite.Areas.Administrator.Controllers
{
    public class NewHeadLineController : Controller
    {
        //
        // GET: /Administrator/NewHeadLine/
      private readonly FashionSiteContext _headlineContext;
      private  readonly ModelHeadLine _modelHeadLine;
       
        public NewHeadLineController()
        {
            _headlineContext = new FashionSiteContext();
            _modelHeadLine = new ModelHeadLine();
          
        }
        public ActionResult Index()
        {
            var comingCategories = _headlineContext.Categories.OrderBy(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [HttpPost, ValidateInput(false)]
        public ActionResult Add(HttpPostedFileBase files, HeadLineTable headlineTable, string category,string language)
        {
           
            var seo = Seo.Seo.Translate(headlineTable.HeadLineTitle);
            if (files != null)
            {
                if (language!=null)
                {
                    var path = Path.Combine(Server.MapPath("~/Content/Images/HeadLine/") + headlineTable.HeadLineTitle.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-") + files.FileName.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-"));

                    _modelHeadLine.Add(headlineTable.HeadLineTitle, headlineTable.HeadLineContent, headlineTable.HeadLineTitle.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-") + files.FileName.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-"), seo, category,language);


                    files.SaveAs(path);
                    return RedirectToAction("index", "allheadline");
                
                }

                else
                {
                    return RedirectToAction("index", "newheadline");
                }
               

               
            }
         
            else
            {
                return RedirectToAction("index", "newheadline");
            }
        }

    }
}
