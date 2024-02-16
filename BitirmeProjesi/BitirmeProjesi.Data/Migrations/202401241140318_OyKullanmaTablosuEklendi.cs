namespace BitirmeProjesi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OyKullanmaTablosuEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OyKullanmaTablosu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SecimId = c.Int(nullable: false),
                        AdayId = c.Int(nullable: false),
                        OyTarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aday", t => t.AdayId, cascadeDelete: true)
                .ForeignKey("dbo.Secim", t => t.SecimId)
                .Index(t => t.SecimId)
                .Index(t => t.AdayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OyKullanmaTablosu", "SecimId", "dbo.Secim");
            DropForeignKey("dbo.OyKullanmaTablosu", "AdayId", "dbo.Aday");
            DropIndex("dbo.OyKullanmaTablosu", new[] { "AdayId" });
            DropIndex("dbo.OyKullanmaTablosu", new[] { "SecimId" });
            DropTable("dbo.OyKullanmaTablosu");
        }
    }
}
