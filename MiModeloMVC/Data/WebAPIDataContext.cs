using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiModeloMVC.Models;

    public class WebAPIDataContext : DbContext
    {
        public WebAPIDataContext (DbContextOptions<WebAPIDataContext> options)
            : base(options)
        {
        }

        public DbSet<MiModeloMVC.Models.Clientes> Clientes { get; set; }
    }
