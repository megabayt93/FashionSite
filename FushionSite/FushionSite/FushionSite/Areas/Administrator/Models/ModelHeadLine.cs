using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.HeadLineEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FashionSite.Areas.Administrator.Models
{
    public class ModelHeadLine
    {
       private  readonly FashionSiteContext _headlineContext;
       private  readonly HeadLineTable _headlineTable;
        public ModelHeadLine()
        {

            _headlineTable = new HeadLineTable();
            _headlineContext = new FashionSiteContext();
        }

        public void Add(string headlineTitle, string headlineContent, string headlineImageUrl, string seo, string category,string language)
        {
            _headlineTable.HeadLineTitle = headlineTitle;
            _headlineTable.HeadLineContent = headlineContent;
            _headlineTable.HeadLineImageUrl = headlineImageUrl;
            _headlineTable.HeadLineSeo = seo;
            _headlineTable.HeadLineCategory = category;
            _headlineTable.Language = language;
            _headlineContext.HeadLine.Add(_headlineTable);
            _headlineContext.SaveChanges();
        }

        public void Update(int id, string headlineTitle, string headlineContent, string headlineImageUrl, string seo, string category)
        {
            var update = _headlineContext.HeadLine.First(hlId => hlId.HeadLineId == id);
            update.HeadLineTitle = headlineTitle;
            update.HeadLineContent = headlineContent;
            update.HeadLineImageUrl = headlineImageUrl;
            update.HeadLineSeo = seo;
            update.HeadLineCategory = category;
            _headlineContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _headlineContext.HeadLine.FirstOrDefault(hlId => hlId.HeadLineId == id);
            _headlineContext.HeadLine.Remove(delete);
            _headlineContext.SaveChanges();
        }
    }
}