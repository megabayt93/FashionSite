using FashionSite.Areas.Administrator.Models;
using FashionSiteEntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FashionSite.Areas.Administrator.Controllers
{
    public class NewCategoryController : Controller
    {
        //
        // GET: /Administrator/NewCategory/
       private readonly ModelCategory _modelCategory;
       private readonly FashionSiteContext _categoryContext;
        public NewCategoryController()
        {
            _categoryContext = new FashionSiteContext();
            _modelCategory = new ModelCategory();
        }
        public ActionResult Index()
        {
            var comingCategories = _categoryContext.Categories.Where(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;
            return View();
        }

        public ActionResult CategoryAdd(string categoryName)
        {
            var seo = Seo.Seo.Translate(categoryName);
            _modelCategory.Add(categoryName, seo);
            return RedirectToAction("index", "newcategory");
        }

        public ActionResult Delete(int id)
        {
            _modelCategory.Delete(id);
            return RedirectToAction("index", "newcategory");
        }

    }
}
