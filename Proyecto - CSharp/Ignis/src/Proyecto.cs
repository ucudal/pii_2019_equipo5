using System;

namespace Ignis 
{   
    public class Proyecto
    {
        public Proyecto(string Nombre, string Descripcion) 
        {
            this.nombre = Nombre;
            this.descripcion = Descripcion;
            this.status = statusIni.Valor;
        }
    
        private string nombre { get; set; } 
        public string Nombre  
        { 
            get { return this.nombre; } 
            set { this.nombre = value; }
        }

        private string descripcion { get; set; } 
        public string Descripcion  
        { 
            get { return this.descripcion; } 
            set { this.descripcion = value; }
        }

        private bool status { get; set; } 
        public bool Status 
        {
            get => this.status;
            protected set {}
        }
        private Status statusIni = new Status(true);
    }
}
