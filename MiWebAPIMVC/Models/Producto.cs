using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MiWebAPIMVC.Models
{
    public class Producto
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public string Categoria {get; set;}
        public int Precio {get; set;}
    }
    
    public class ApplicationDbContext: DbContext {
        public ApplicationDbContext() {
        }

        public DbSet<Producto> Producto {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("DataSource=app.db");
        }
    }
}