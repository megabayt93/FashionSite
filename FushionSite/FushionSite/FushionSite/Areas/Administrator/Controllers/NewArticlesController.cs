using FashionSite.Areas.Administrator.Models;
using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.ArticlesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FashionSite.Areas.Administrator.Controllers
{
    public class NewArticlesController : Controller
    {
        //
        // GET: /Administrator/NewArticles/
        private readonly FashionSiteContext _articlesContext;
        private readonly FashionSite.Areas.Administrator.Models.ModelArticle _modelArticle;

        public NewArticlesController()
        {
            _modelArticle = new ModelArticle();

            _articlesContext = new FashionSiteContext();
        }
        public ActionResult Index()
        {
            var comingCategories = _articlesContext.Categories.Where(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [HttpPost, ValidateInput(false)]
        public JavaScriptResult Add(ArticlesTable articleTable, string category, string language)
        {
            var seo = Seo.Seo.Translate(articleTable.ArticleTitle);
            if (category != null)
            {
                if (language != null)
                {
                    _modelArticle.Add(articleTable.ArticleTitle, articleTable.ArticleContent, category, seo, language);
                    string rtrn = "$('#divError').html('<img src=/Areas/Administrator/Images/ajax-loader.gif class=loaderGif></img>'); window.location='/administrator/allarticles'";
                    return JavaScript(rtrn);

                }
                else
                {
                    string rtrn = "$('#divError').html('Dil Seçiniz');";
                    return JavaScript(rtrn);
                }




            }
            else
            {
                string rtrn = "$('#divError').html('Kategori Seçiniz');";
                return JavaScript(rtrn);


            }

        }

    }
}
