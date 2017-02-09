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
    public class AllHeadLineController : Controller
    {
        //
        // GET: /Administrator/AllHeadLine/
       private readonly FashionSiteContext _headlineContext;
    
       private readonly ModelHeadLine _modelHeadLine;
        public AllHeadLineController()
        {
            _modelHeadLine = new ModelHeadLine();
            _headlineContext = new FashionSiteContext();
          
        }
        public ActionResult Index()
        {
            var comingHeadLines = _headlineContext.HeadLine.Where(hlId => hlId.HeadLineId> 0);
            ViewBag.SendHeadLines = comingHeadLines;
            var comingCategories = _headlineContext.Categories.OrderBy(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;
            return View();
        }


        public ActionResult UpdateIndex(int id)
        {
            var comingCategories = _headlineContext.Categories.OrderBy(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;
            var updateHeadLine = _headlineContext.HeadLine.First(hlId => hlId.HeadLineId == id);
            return View(updateHeadLine);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [HttpPost, ValidateInput(false)]
        public ActionResult Update(HttpPostedFileBase files,HeadLineTable headlineTable, string category)
        {
            var seo = Seo.Seo.Translate(headlineTable.HeadLineTitle);
            if (files != null)
            {

                var path = Path.Combine(Server.MapPath("~/Content/Images/HeadLine/") + headlineTable.HeadLineTitle.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-") + files.FileName.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-"));

                _modelHeadLine.Update(headlineTable.HeadLineId, headlineTable.HeadLineTitle, headlineTable.HeadLineContent, headlineTable.HeadLineTitle.Replace(' ', '-') + files.FileName.Replace(' ', '-').Replace('+', '-').Replace("'", "-").Replace("*", "-").Replace("!", "-").Replace("?", "-"), seo, category);

               
                files.SaveAs(path);
                return RedirectToAction("index", "allheadline");
            }

            else
            {


                _modelHeadLine.Update(headlineTable.HeadLineId, headlineTable.HeadLineTitle, headlineTable.HeadLineContent, headlineTable.HeadLineImageUrl, seo, category);

              
                return RedirectToAction("index", "allheadline");
            }
                  
        }

        public ActionResult Delete(int id)
        {
            _modelHeadLine.Delete(id);
            return RedirectToAction("index", "allheadline");
        }

    }
}
