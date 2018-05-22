namespace MiCodeFirst_DataAnnotations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlumnosInfoSchema : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.AlumnosInfo", newSchema: "Admin");
        }
        
        public override void Down()
        {
            MoveTable(name: "Admin.AlumnosInfo", newSchema: "dbo");
        }
    }
}
