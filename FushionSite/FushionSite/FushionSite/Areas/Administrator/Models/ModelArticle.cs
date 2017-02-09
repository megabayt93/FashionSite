using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.ArticlesEntity;

namespace FashionSite.Areas.Administrator.Models
{

    public class ModelArticle
    {

       private  readonly FashionSiteContext _articleContext;
       private readonly ArticlesTable _articlesTable;
        public ModelArticle()
        {
            _articlesTable = new ArticlesTable();
            _articleContext = new FashionSiteContext();
        }

        public void Add(string articleTitle, string articleContent, string articleCategory, string articleSeo, string language)
        {
            _articlesTable.ArticleTitle = articleTitle;
            _articlesTable.ArticleContent = articleContent;
            _articlesTable.ArticleCategory = articleCategory;
            _articlesTable.ArticleSeo = articleSeo;
            _articlesTable.Language = language;
            _articleContext.Articles.Add(_articlesTable);
            _articleContext.SaveChanges();


        }

        public void Update(int id, string articleTitle, string articleContent, string categoryName, string seo)
        {
            var update = _articleContext.Articles.First(aId => aId.ArticleId == id);
            update.ArticleTitle = articleTitle;
            update.ArticleContent = articleContent;
            update.ArticleCategory = categoryName;
            update.ArticleSeo = seo;
            _articleContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _articleContext.Articles.FirstOrDefault(aId => aId.ArticleId == id);

            _articleContext.Articles.Remove(delete);
            _articleContext.SaveChanges();
        }



    }
}