using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FashionSiteEntityLibrary;

namespace FushionSite.Models
{
    public class ComingData
    {
        private readonly FashionSiteContext _dataContext;

        public ComingData()
        {
            _dataContext = new FashionSiteContext();
        }

        public object GalleryData(string category, int skip, int take)
        {
            if (take == 0)
            {
                var comingGallery = (from p in _dataContext.Gallery select p).Where(gC => gC.Category == category).OrderByDescending(gId => gId.GalleryId);
                return comingGallery;
            }
            else
            {
                var comingGallery = (from p in _dataContext.Gallery select p).Where(gC => gC.Category == category).OrderByDescending(gId => gId.GalleryId).Skip(skip).Take(take);
                return comingGallery;
            }





        }

        public object HomeData(string language)
        {
            var comingSlider =
               (from p in _dataContext.HeadLine select p).Where(sC => sC.HeadLineCategory == "Anasayfa Slider").Where(sL => sL.Language == "Türkçe");
            return comingSlider;
        }

        public object Articles(string language, string category)
        {
            var comingArticles = _dataContext.Articles.Where(iL => iL.Language == language).FirstOrDefault(iId => iId.ArticleCategory == category);
            return comingArticles;
        }

        public object Contact(string language)
        {
            var comingContact = _dataContext.Contacts.FirstOrDefault(id => id.ContactId > 0);
            return comingContact;
        }


    }
}