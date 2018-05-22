namespace MiCodeFirst_DataAnnotations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alumnosinfo : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "AlumnosInfo");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AlumnosInfo", newName: "Alumnoes");
        }
    }
}
