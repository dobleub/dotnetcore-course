using System;

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
}