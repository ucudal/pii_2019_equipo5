using System;

namespace Ignis
{
    public class Proyecto
    {
        public Proyecto(string  Nombre, string Presentacion, string Estado)
        {
            this.nombre=Nombre;
            this.presentacion=Presentacion;
            this.estado=Estado;
        }
        private string nombre{ get; set; }
        private string presentacion{ get; set; }
        private string estado{get;set;}
    }
}