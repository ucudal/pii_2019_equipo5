using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesIgnis.Models
{
    public class Tecnico
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}