using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MiWebAPIMVC.Models;

namespace MiWebAPIMVC.Models
{
    public class Venta
    {
        public int ID {get; set;}
        public int ClienteID {get; set;}
        public int ProductoID {get; set;}
        public int Cantidad {get; set;}
        public int Subtotal {
            get { return Cantidad; }
        }

        public Cliente Cliente {get; set;}
        public Producto Producto {get; set;}
    }
}