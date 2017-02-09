using FashionSiteEntityLibrary.AdminInformationEntity;
using FashionSiteEntityLibrary.ArticlesEntity;
using FashionSiteEntityLibrary.CategoryEntity;
using FashionSiteEntityLibrary.ContactEntity;
using FashionSiteEntityLibrary.GalleryEntiy;
using FashionSiteEntityLibrary.HeadLineEntity;
using FashionSiteEntityLibrary.MediaEntity;
using System.Data.Entity;
using FushionSiteEntityLibrary;


namespace FashionSiteEntityLibrary
{
    public class FashionSiteContext : DbContext
    {
        public FashionSiteContext()
        {
            Database.SetInitializer<FashionSiteContext>(new FashionSiteInitializer());
        }
        public DbSet<AdminInformationTable> Admin { get; set; }
        public DbSet<MediasTable> Medias { get; set; }

        public DbSet<HeadLineTable> HeadLine { get; set; }

        public DbSet<GalleryTable> Gallery { get; set; }

        public DbSet<CategoriesTable> Categories { get; set; }

        public DbSet<ArticlesTable> Articles { get; set; }

        public DbSet<ContactsTable> Contacts { get; set; }
    }
}
