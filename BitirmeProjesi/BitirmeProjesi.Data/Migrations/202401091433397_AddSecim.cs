namespace BitirmeProjesi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSecim : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Secim", "SecimBaslangic", c => c.DateTime(nullable: false));
            AddColumn("dbo.Secim", "SecimBitis", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Secim", "SecimBitis");
            DropColumn("dbo.Secim", "SecimBaslangic");
        }
    }
}
