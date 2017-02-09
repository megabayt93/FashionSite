using FashionSite.Areas.Administrator.Models;
using FashionSiteEntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionSiteEntityLibrary.CategoryEntity;

namespace FashionSite.Areas.Administrator.Controllers
{
    public class AllCategoryController : Controller
    {
        //
        // GET: /Administrator/AllCategory/
       private readonly FashionSiteContext _categoryContext;
       private readonly ModelCategory _modelCategory;
        public AllCategoryController()
        {
            _modelCategory = new ModelCategory();
            _categoryContext = new FashionSiteContext();
        }
        public ActionResult Index()
        {
            var comingCategories = _categoryContext.Categories.Where(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;
            return View();
        }

        public ActionResult Delete(int id)
        {
            _modelCategory.Delete(id);
            return RedirectToAction("index", "allcategory");
        }

        public ActionResult UpdateIndex(int id)
        {
            var comingCategories = _categoryContext.Categories.Where(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;

            var updateCategory = _categoryContext.Categories.First(cId => cId.CategoryId == id);
            return View(updateCategory);
        }

        public ActionResult Update(CategoriesTable categorytable)
        {
            
            var seo = Seo.Seo.Translate(categorytable.CategoryName);
            _modelCategory.Update(categorytable.CategoryId, categorytable.CategoryName, seo);
            return RedirectToAction("index", "allcategory");
        }

    }
}
