using KagiEntityLibrary.AdminInformationEntity;
using KagiEntityLibrary.ArticlesEntity;
using KagiEntityLibrary.CategoryEntity;
using KagiEntityLibrary.ContactEntity;
using KagiEntityLibrary.GalleryEntiy;
using KagiEntityLibrary.HeadLineEntity;
using KagiEntityLibrary.MediaEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace FushionSiteEntityLibrary
{
    public class FushionSiteContext : DbContext
    {
        public DbSet<AdminInformationTable> Admin { get; set; }
        public DbSet<MediasTable> Medias { get; set; }

        public DbSet<HeadLineTable> HeadLine { get; set; }

        public DbSet<GalleryTable> Gallery { get; set; }

        public DbSet<CategoriesTable> Categories { get; set; }

        public DbSet<ArticlesTable> Articles { get; set; }

        public DbSet<ContactsTable> Contacts { get; set; }
    }
}
