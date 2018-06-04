using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
}