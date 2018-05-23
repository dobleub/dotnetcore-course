using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiWebAPIMVC.Models;

    public class WebAPIDataContext : DbContext
    {
        public WebAPIDataContext (DbContextOptions<WebAPIDataContext> options)
            : base(options)
        {
        }

        public DbSet<MiWebAPIMVC.Models.Producto> Producto { get; set; }
    }
