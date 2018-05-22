namespace MiCodeFirst_DataAnnotations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        AluID = c.Int(nullable: false, identity: true),
                        Apellidos = c.String(),
                        Nombre = c.String(),
                        FechaMatricula = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AluID);
            
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        MatriculaID = c.Int(nullable: false, identity: true),
                        CursoID = c.Int(nullable: false),
                        AlumnoID = c.Int(nullable: false),
                        Precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatriculaID)
                .ForeignKey("dbo.Alumnoes", t => t.AlumnoID, cascadeDelete: true)
                .Index(t => t.AlumnoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "AlumnoID", "dbo.Alumnoes");
            DropIndex("dbo.Matriculas", new[] { "AlumnoID" });
            DropTable("dbo.Matriculas");
            DropTable("dbo.Alumnoes");
        }
    }
}
