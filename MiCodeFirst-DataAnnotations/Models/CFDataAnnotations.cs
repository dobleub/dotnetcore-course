using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiCodeFirst_DataAnnotations.Models
{
    public class CFDataAnnotations
    {
    }

    [Table("AlumnosInfo", Schema ="Admin")]
    public class Alumno
    {
        [Key]
        public int AluID { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaMatricula { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; }
    }
    public class AlumnoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public AlumnoContext() : base("name=AlumnoContext")
        {
        }

        public System.Data.Entity.DbSet<MiCodeFirst_DataAnnotations.Models.Alumno> Alumnoes { get; set; }
    }
    public class LicenciaConducir
    {
        [Key, Column(Order = 1)]
        public int NumeroLicencia { get; set; }
        [Key, Column(Order = 2)]
        public string Pais { get; set; }
        public DateTime Expedido { get; set; }
        public DateTime Caduca { get; set; }

    }
    public class LicenciaConducirContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public LicenciaConducirContext() : base("name=LicenciaConducirContext")
        {
        }

        public System.Data.Entity.DbSet<MiCodeFirst_DataAnnotations.Models.LicenciaConducir> LicenciaConducirs { get; set; }
    }

    public class Curso
    {
        public int CursoID { get; set; }
        public string TipoCarnet { get; set; }
        public int NumeroClases { get; set; }
        [Timestamp]
        public byte[] TStamp { get; set; }
        [Index]
        public int creditos { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; }

    }
    public class CursoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public CursoContext() : base("name=CursoContext")
        {
        }

        public System.Data.Entity.DbSet<MiCodeFirst_DataAnnotations.Models.Curso> Cursoes { get; set; }
    }

    public class Matricula
    {
        public int MatriculaID { get; set; }
        public int CursoID { get; set; }
        public int AlumnoID { get; set; }
        public int Precio { get; set; }
       
        [ForeignKey("AlumnoID")]
        public virtual Alumno Alumno { get; set; }

    }
    public class MatriculaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public MatriculaContext() : base("name=MatriculaContext")
        {
        }

        public System.Data.Entity.DbSet<MiCodeFirst_DataAnnotations.Models.Matricula> Matriculas { get; set; }

        public System.Data.Entity.DbSet<MiCodeFirst_DataAnnotations.Models.Alumno> Alumnoes { get; set; }
    }

}