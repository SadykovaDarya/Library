namespace LibraryData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        Genre = c.String(),
                        Reader_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Readers", t => t.Reader_ID)
                .Index(t => t.Reader_ID);
            
            CreateTable(
                "dbo.Readers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abonement = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Reader_ID", "dbo.Readers");
            DropIndex("dbo.Books", new[] { "Reader_ID" });
            DropTable("dbo.Readers");
            DropTable("dbo.Books");
        }
    }
}
