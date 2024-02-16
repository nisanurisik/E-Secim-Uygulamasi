namespace BitirmeProjesi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aday",
                c => new
                    {
                        AdayId = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        SecimId = c.Int(nullable: false),
                        AdayParti = c.String(),
                    })
                .PrimaryKey(t => t.AdayId)
                .ForeignKey("dbo.Kullanicilar", t => t.KullaniciId, cascadeDelete: true)
                .ForeignKey("dbo.Secim", t => t.SecimId, cascadeDelete: true)
                .Index(t => t.KullaniciId)
                .Index(t => t.SecimId);
            
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        KullaniciSoyadi = c.String(),
                        KullaniciTc = c.String(),
                        KullaniciDogumTarihi = c.DateTime(nullable: false),
                        IlceId = c.Int(nullable: false),
                        KullaniciYetki = c.String(),
                        KullaniciOyDurumu = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciId)
                .ForeignKey("dbo.Ilce", t => t.IlceId, cascadeDelete: true)
                .Index(t => t.IlceId);
            
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        IlceId = c.Int(nullable: false, identity: true),
                        SehirId = c.Int(nullable: false),
                        IlceAdi = c.String(),
                    })
                .PrimaryKey(t => t.IlceId)
                .ForeignKey("dbo.Sehir", t => t.SehirId, cascadeDelete: true)
                .Index(t => t.SehirId);
            
            CreateTable(
                "dbo.Sehir",
                c => new
                    {
                        SehirId = c.Int(nullable: false, identity: true),
                        SehirAdi = c.String(),
                    })
                .PrimaryKey(t => t.SehirId);
            
            CreateTable(
                "dbo.Secim",
                c => new
                    {
                        SecimId = c.Int(nullable: false, identity: true),
                        SecimAdi = c.String(),
                    })
                .PrimaryKey(t => t.SecimId);
            
            CreateTable(
                "dbo.Kampanya",
                c => new
                    {
                        KampanyaId = c.Int(nullable: false, identity: true),
                        KampanyaBaslik = c.String(),
                        KampanyaMetni = c.String(),
                    })
                .PrimaryKey(t => t.KampanyaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aday", "SecimId", "dbo.Secim");
            DropForeignKey("dbo.Aday", "KullaniciId", "dbo.Kullanicilar");
            DropForeignKey("dbo.Kullanicilar", "IlceId", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "SehirId", "dbo.Sehir");
            DropIndex("dbo.Ilce", new[] { "SehirId" });
            DropIndex("dbo.Kullanicilar", new[] { "IlceId" });
            DropIndex("dbo.Aday", new[] { "SecimId" });
            DropIndex("dbo.Aday", new[] { "KullaniciId" });
            DropTable("dbo.Kampanya");
            DropTable("dbo.Secim");
            DropTable("dbo.Sehir");
            DropTable("dbo.Ilce");
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.Aday");
        }
    }
}
