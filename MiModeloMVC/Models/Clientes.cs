using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiModeloMVC.Models
{
    public class Clientes
    {
        // {get; } Consultar su valor
        // {set; } Establecer su valor
        public int ID {get; set;}
        
        [StringLength (60, MinimumLength=3)]
        public string nombre {get; set;}

        [Display (Name="Fecha de Alta")]
        [DataType (DataType.Date)]
        [DisplayFormat (DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime fechaAlta {get; set;}

        [Range (18, 75)]
        public int edad {get; set;}
    }

    public class EmpDBContext : DbContext
    {
        public EmpDBContext () {

        }

        public DbSet<Clientes> Clientes {get; set;}

        
        // use this if not was configured in by dependency injection in Startup.ConfigureServices
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=clientes.db");
        }
       
    }
}