namespace DataAnnotationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adresler : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adreslers",
                c => new
                    {
                        AdresId = c.Int(nullable: false, identity: true),
                        Adres1 = c.String(maxLength: 500),
                        Adres2 = c.String(maxLength: 500),
                        Telefon = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.AdresId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Adreslers");
        }
    }
}
