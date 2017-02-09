namespace KagiEntityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminInformationTables",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        AdminName = c.String(nullable: false),
                        AdminPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.ArticlesTables",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        ArticleTitle = c.String(nullable: false),
                        ArticleContent = c.String(),
                        ArticleSeo = c.String(),
                        ArticleCategory = c.String(),
                        ArticleImage = c.String(),
                    })
                .PrimaryKey(t => t.ArticleId);
            
            CreateTable(
                "dbo.CategoriesTables",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                        CategorySeo = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ContactsTables",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        ContactContent = c.String(),
                        Language = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.GalleryTables",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        ImageUrl = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.GalleryId);
            
            CreateTable(
                "dbo.HeadLineTables",
                c => new
                    {
                        HeadLineId = c.Int(nullable: false, identity: true),
                        HeadLineTitle = c.String(nullable: false),
                        HeadLineCategory = c.String(),
                        HeadLineContent = c.String(),
                        Language = c.String(),
                        HeadLineImageUrl = c.String(),
                        HeadLineSeo = c.String(),
                    })
                .PrimaryKey(t => t.HeadLineId);
            
            CreateTable(
                "dbo.MediasTables",
                c => new
                    {
                        MediaId = c.Int(nullable: false, identity: true),
                        MediaUrl = c.String(),
                    })
                .PrimaryKey(t => t.MediaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MediasTables");
            DropTable("dbo.HeadLineTables");
            DropTable("dbo.GalleryTables");
            DropTable("dbo.ContactsTables");
            DropTable("dbo.CategoriesTables");
            DropTable("dbo.ArticlesTables");
            DropTable("dbo.AdminInformationTables");
        }
    }
}
