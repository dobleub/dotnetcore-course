using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MiWebAPIMVC.Models
{
    public class Cliente
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public string Email {get; set;}
    }
}