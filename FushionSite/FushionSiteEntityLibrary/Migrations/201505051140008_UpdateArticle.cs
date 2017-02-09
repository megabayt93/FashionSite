namespace KagiEntityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateArticle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArticlesTables", "Language", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ArticlesTables", "Language");
        }
    }
}
