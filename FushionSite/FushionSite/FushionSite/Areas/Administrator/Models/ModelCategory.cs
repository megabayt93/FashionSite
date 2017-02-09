using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.CategoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FashionSite.Areas.Administrator.Models
{
    public class ModelCategory
    {
       private readonly FashionSiteContext _categoryContext;
       private  readonly CategoriesTable _categoryTable;

        public ModelCategory()
        {
            _categoryContext = new FashionSiteContext();
            _categoryTable = new CategoriesTable();
        }

        public void Add(string categoryName, string seo)
        {
            _categoryTable.CategoryName = categoryName;
            _categoryTable.CategorySeo = seo;
            _categoryContext.Categories.Add(_categoryTable);
            _categoryContext.SaveChanges();


        }

        public void Update(int id,string categoryName,string seo)
        {
            var update = _categoryContext.Categories.First(cId => cId.CategoryId == id);
            update.CategoryName = categoryName;
            update.CategorySeo = seo;
            _categoryContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _categoryContext.Categories.FirstOrDefault(cId => cId.CategoryId == id);

            _categoryContext.Categories.Remove(delete);
            _categoryContext.SaveChanges();
        }

    }
}