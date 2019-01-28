namespace DataAnnotationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adres : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Adreslers", newName: "Adres");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Adres", newName: "Adreslers");
        }
    }
}
