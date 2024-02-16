namespace BitirmeProjesi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OyEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Oy",
                c => new
                    {
                        SecId = c.Int(nullable: false, identity: true),
                        SecAdi = c.String(),
                        SecBaslangic = c.DateTime(nullable: false),
                        SecBitis = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SecId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Oy");
        }
    }
}
