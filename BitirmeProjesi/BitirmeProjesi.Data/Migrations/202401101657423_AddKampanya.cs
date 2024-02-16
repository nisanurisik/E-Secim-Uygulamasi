namespace BitirmeProjesi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKampanya : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kampanya", "KampanyaAday", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kampanya", "KampanyaAday");
        }
    }
}
