using FashionSite.Areas.Administrator.Models;
using System.Linq;
using System.Web.Mvc;
using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.ArticlesEntity;


namespace FashionSite.Areas.Administrator.Controllers
{
    public class AllArticlesController : Controller
    {
        //
        // GET: /Administrator/AllArticles/
        private readonly FashionSiteContext _articleContext;
        private readonly ModelArticle _modelArticle;

        public AllArticlesController()
        {
            _modelArticle = new ModelArticle();
            _articleContext = new FashionSiteContext();

        }
        public ActionResult Index()
        {
            var comingArticles = _articleContext.Articles.Where(aId => aId.ArticleId > 0);
            ViewBag.SendArticles = comingArticles;
            return View();
        }

        public ActionResult UpdateIndex(int id)
        {
            var comingCategories = _articleContext.Categories.Where(cId => cId.CategoryId > 0);
            ViewBag.SendCategories = comingCategories;

            var updateArticles = _articleContext.Articles.First(aId => aId.ArticleId == id);
            return View(updateArticles);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [HttpPost, ValidateInput(false)]
        public JavaScriptResult Update(ArticlesTable articleTable, string category)
        {

            var seo = Seo.Seo.Translate(articleTable.ArticleTitle);
            if (category != null)
            {
                _modelArticle.Update(articleTable.ArticleId, articleTable.ArticleTitle, articleTable.ArticleContent, category, seo);
                string rtrn = "$('#divError').html('<img src=/Areas/Administrator/Images/ajax-loader.gif class=loaderGif></img>'); window.location='/administrator/allarticles'";
                return JavaScript(rtrn);
            }
            else
            {
                string rtrn = "$('#divError').html('Kategori Seçiniz');";
                return JavaScript(rtrn);


            }
        }

        public ActionResult Delete(int id)
        {
            _modelArticle.Delete(id);
            return RedirectToAction("index", "allarticles");
        }
    }
}
