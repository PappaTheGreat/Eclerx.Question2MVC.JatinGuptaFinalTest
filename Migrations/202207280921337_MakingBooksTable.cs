namespace Eclerx.Question2MVC.JatinGupta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakingBooksTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ISBN = c.String(nullable: false),
                        BookName = c.String(nullable: false),
                        Genre = c.String(nullable: false),
                        AuthorName = c.String(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        PublishedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
