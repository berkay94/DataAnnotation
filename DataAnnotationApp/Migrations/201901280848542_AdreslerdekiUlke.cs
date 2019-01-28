namespace DataAnnotationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdreslerdekiUlke : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adres", "Ulke", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Adres", "Ulke");
        }
    }
}
