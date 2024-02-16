namespace BitirmeProjesi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OyGüncellendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Oy", "SecAday", c => c.String());
            DropColumn("dbo.Oy", "SecBaslangic");
            DropColumn("dbo.Oy", "SecBitis");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Oy", "SecBitis", c => c.DateTime(nullable: false));
            AddColumn("dbo.Oy", "SecBaslangic", c => c.DateTime(nullable: false));
            DropColumn("dbo.Oy", "SecAday");
        }
    }
}
