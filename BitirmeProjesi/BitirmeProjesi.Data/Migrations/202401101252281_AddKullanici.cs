namespace BitirmeProjesi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKullanici : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kullanicilar", "KullaniciSifre", c => c.String(nullable: false));
            AddColumn("dbo.Kullanicilar", "KullaniciGirisAdi", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kullanicilar", "KullaniciGirisAdi");
            DropColumn("dbo.Kullanicilar", "KullaniciSifre");
        }
    }
}
