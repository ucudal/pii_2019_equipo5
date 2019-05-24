using System;

namespace Ignis
{
    public class Proyecto
    {
        public Proyecto(string  Nombre, string Descripcion)
        {
            this.nombre=Nombre;
            this.descripcion=Descripcion;
        }
        private string nombre{ get; set; }
        private string descripcion { get; set; }
    }
}