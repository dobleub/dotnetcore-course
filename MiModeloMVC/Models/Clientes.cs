using System;
using Microsoft.EntityFrameworkCore;

namespace MiModeloMVC.Models
{
    public class Clientes
    {
        // {get; } Consultar su valor
        // {set; } Establecer su valor
        public int ID {get; set;}
        public string nombre {get; set;}
        public DateTime fechaAlta {get; set;}
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