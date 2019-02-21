namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sex = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HumanNumber = c.String(),
                        Director_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Directors", t => t.Director_ID)
                .Index(t => t.Director_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Director_ID", "dbo.Directors");
            DropIndex("dbo.Movies", new[] { "Director_ID" });
            DropTable("dbo.Movies");
            DropTable("dbo.Directors");
        }
    }
}
