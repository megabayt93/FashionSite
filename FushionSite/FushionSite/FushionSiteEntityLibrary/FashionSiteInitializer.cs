using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.ArticlesEntity;
using FashionSiteEntityLibrary.CategoryEntity;
using FashionSiteEntityLibrary.ContactEntity;
using FashionSiteEntityLibrary.GalleryEntiy;
using FashionSiteEntityLibrary.HeadLineEntity;


namespace FushionSiteEntityLibrary
{
    internal class FashionSiteInitializer : CreateDatabaseIfNotExists<FashionSiteContext>
    {
        public FashionSiteInitializer() { }

        protected override void Seed(FashionSiteContext context)
        {
            base.Seed(context);

            using (var ctxcontext = new FashionSiteContext())
            {
                #region InstutionalFirstProcessRegion
                string category = "Hakkımızda";
                for (int i = 0; i < 5; i++)
                {
                    if (i == 1)
                    {
                        category = "Misyonumuz";

                    }
                    else if (i == 2)
                    {
                        category = "Vizyonumuz";
                    }
                    else if (i == 3)
                    {
                        category = "Referanslar";
                    }

                    else if (i == 4)
                    {
                        category = "Hizmetler";
                    }

                    ctxcontext.Articles.Add(
                  new ArticlesTable()
                  {
                      ArticleCategory = category,
                      ArticleContent = "Bir şey yɑp, güzel olsun. Çok mu zor? O vɑkit güzel bir şey söyle. Dilin mi dönmüyor? Güzel bir şey gör veyɑ güzel bir şey yɑz. Beceremez misin? Öyleyse güzel bir şeye bɑşlɑ. Amɑ hep güzel şeyler olsun. Çünkü her insɑn ölecek yɑştɑ. <br>Bɑşlɑmɑk için mükemmel olmɑk zorundɑ değilsin; fɑkɑt mükemmel olmɑk için bɑşlɑmɑk zorundɑsın. ",
                      ArticleTitle = category,
                      ArticleSeo = category = Seo.Seo.Translate(category),
                      ArticleImage = null,
                      Language = "Türkçe"
                  }
              );
                    ctxcontext.SaveChanges();
                    ctxcontext.Articles.Add(
                 new ArticlesTable()
                 {
                     ArticleCategory = category,
                     ArticleContent = "Bir şey yɑp, güzel olsun. Çok mu zor? O vɑkit güzel bir şey söyle. Dilin mi dönmüyor? Güzel bir şey gör veyɑ güzel bir şey yɑz. Beceremez misin? Öyleyse güzel bir şeye bɑşlɑ. Amɑ hep güzel şeyler olsun. Çünkü her insɑn ölecek yɑştɑ. <br>Bɑşlɑmɑk için mükemmel olmɑk zorundɑ değilsin; fɑkɑt mükemmel olmɑk için bɑşlɑmɑk zorundɑsın. ",
                     ArticleTitle = category,
                     ArticleSeo = category = Seo.Seo.Translate(category),
                     ArticleImage = null,
                     Language = "İngilizce"
                 }
             );
                    ctxcontext.SaveChanges();
                }
                #endregion

                #region ImageFirstRegion

                for (int i = 0; i < 10; i++)
                {
                    ctxcontext.Gallery.Add(
                       new GalleryTable()
                       {
                           ImageUrl = "Ürünler1.jpg",
                           Category = "Ürünler"
                       }

                    );
                    ctxcontext.SaveChanges();
                }
                for (int i = 0; i < 10; i++)
                {
                    ctxcontext.Gallery.Add(
                       new GalleryTable()
                       {
                           ImageUrl = "Fabrika.jpg",
                           Category = "Fabrika"
                       }
                    );
                    ctxcontext.SaveChanges();
                }
                #endregion

                #region ContentFirstRegion

                for (int i = 0; i < 10; i++)
                {
                    ctxcontext.HeadLine.Add(
                       new HeadLineTable()
                       {
                           HeadLineTitle = "Fashion Kurumsal Proje",
                           HeadLineSeo = "fashion-kurumsal-proje",
                           Language = "Türkçe",
                           HeadLineCategory = "Anasayfa Slider",
                           HeadLineContent = ".NET OPEN SOURCE MVC PROJESİ",
                           HeadLineImageUrl = "Slider.jpg"
                       }
                    );

                    ctxcontext.HeadLine.Add(
                       new HeadLineTable()
                       {
                           HeadLineTitle = "Fashion Instutional Project",
                           HeadLineSeo = "fashion-instutional-project",
                           Language = "İngilizce",
                           HeadLineCategory = "Anasayfa Slider",
                           HeadLineContent = ".NET OPEN SOURCE MVC PROJECT",
                           HeadLineImageUrl = "Slider.jpg"
                       }
                    );
                }

                ctxcontext.Contacts.Add(
                       new ContactsTable()
                       {
                           ContactContent = "<b>Fatih YAZICI<br>Tel: 0530 291 9263<br>e-mail: fatihyazici1010@gmail.com<br>Adres: Kahramanmaraş/Onikişubat<br>Yazılım sektörüne kendini adayacak genç arkadaşlara nacizane hediyemdir.</b>"
                       }
                    );

                #endregion

                #region FirstCategoryRegion

                string categoryDb = "Anasayfa Slider";
                for (int i = 0; i < 8; i++)
                {
                    if (i == 1)
                    {
                        categoryDb = "Ürünler";
                    }

                   else if (i == 2)
                    {
                        categoryDb = "Fabrika";
                    }

                    else if (i == 3)
                    {
                        categoryDb = "Hakkımızda";
                    }

                    else if (i == 4)
                    {
                        categoryDb = "Vizyonumuz";
                    }

                    else if (i == 5)
                    {
                        categoryDb = "Misyonumuz";
                    }
                    else if (i == 6)
                    {
                        categoryDb = "Referanslar";
                    }
                    else if (i == 7)
                    {
                        categoryDb = "Hizmetler";
                    }

                    ctxcontext.Categories.Add(

                   new CategoriesTable()
                   {
                       CategoryName = categoryDb,
                       CategorySeo = Seo.Seo.Translate(categoryDb)

                   }

               );
                    ctxcontext.SaveChanges();
                }



                #endregion


            }
        }
    }
}
