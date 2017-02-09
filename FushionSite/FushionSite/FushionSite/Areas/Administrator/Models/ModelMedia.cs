using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.MediaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FashionSite.Areas.Administrator.Models
{
    public class ModelMedia
    {
       private  readonly FashionSiteContext _mediaContext;
       private readonly MediasTable _mediaTable;

        public ModelMedia()
        {
            _mediaContext = new FashionSiteContext();
            _mediaTable = new MediasTable();
        }

        public void Add(string mediaUrl)
        {
            _mediaTable.MediaUrl = mediaUrl;
            _mediaContext.Medias.Add(_mediaTable);
            _mediaContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var delete = _mediaContext.Medias.FirstOrDefault(mID => mID.MediaId == id);
            _mediaContext.Medias.Remove(delete);
            _mediaContext.SaveChanges();
        }
    }
}