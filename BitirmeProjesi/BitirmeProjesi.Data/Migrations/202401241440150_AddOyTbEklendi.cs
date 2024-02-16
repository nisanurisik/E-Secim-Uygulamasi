namespace BitirmeProjesi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOyTbEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OyKullanTablo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SecimId = c.Int(nullable: false),
                        AdayId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aday", t => t.AdayId, cascadeDelete: true)
                .ForeignKey("dbo.Secim", t => t.SecimId)
                .Index(t => t.SecimId)
                .Index(t => t.AdayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OyKullanTablo", "SecimId", "dbo.Secim");
            DropForeignKey("dbo.OyKullanTablo", "AdayId", "dbo.Aday");
            DropIndex("dbo.OyKullanTablo", new[] { "AdayId" });
            DropIndex("dbo.OyKullanTablo", new[] { "SecimId" });
            DropTable("dbo.OyKullanTablo");
        }
    }
}
