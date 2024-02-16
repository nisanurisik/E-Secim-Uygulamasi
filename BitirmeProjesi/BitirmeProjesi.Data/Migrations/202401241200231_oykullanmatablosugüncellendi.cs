namespace BitirmeProjesi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oykullanmatablosugüncellendi : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OyKullanmaTablosu", "OyTarih");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OyKullanmaTablosu", "OyTarih", c => c.DateTime(nullable: false));
        }
    }
}
