using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.GalleryEntiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FashionSite.Areas.Administrator.Models
{
    public class ModelGallery
    {

        private readonly FashionSiteContext _galleryContext;
        private readonly GalleryTable _galleryTable;
        public ModelGallery()
        {
            _galleryContext = new FashionSiteContext();
            _galleryTable = new GalleryTable();
        }


        public void Add(string galleryUrl, string galleryCategory)
        {
            _galleryTable.ImageUrl = galleryUrl;
            _galleryTable.Category = galleryCategory;
            _galleryContext.Gallery.Add(_galleryTable);
            _galleryContext.SaveChanges();

        }

        public void Delete(int id)
        {
            var delete = _galleryContext.Gallery.FirstOrDefault(gID => gID.GalleryId == id);

            _galleryContext.Gallery.Remove(delete);
            _galleryContext.SaveChanges();
        }

    }
}