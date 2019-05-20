using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Proyecto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public string Estado { get; set; }
    }
}