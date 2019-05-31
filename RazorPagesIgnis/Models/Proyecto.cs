using System;
using System.Collections.Generic;

namespace Ignis 
{   
    public class Proyecto
    {
        public Proyecto(string Nombre, string Descripcion) 
        {
            this.nombre = Nombre;
            this.descripcion = Descripcion;
            this.status = true;

            List<Solicitud> ListaDeSolicitudes = new List<Solicitud>();
            this.listaSolicitudes = ListaDeSolicitudes;
        }
    
        public int ID { get; set; }
        
        private string nombre;
        public string Nombre  
        { 
            get => this.nombre; 
            protected set {}
        }

        private string descripcion;
        public string Descripcion  
        { 
            get => this.descripcion; 
            set => this.descripcion = value;
        }

        private bool status;
        public bool Status 
        {
            get => this.status;
            protected set {}
        }

        private List<Solicitud> listaSolicitudes;
        public List<Solicitud> ListaDeSolicitudes 
        {
            get => this.listaSolicitudes;
            protected set {}
        }

        public void AsociarSolicitud_a_Proyecto(Solicitud nuevaSolicitud) 
        {
            ListaDeSolicitudes.Add(nuevaSolicitud);
        }

        public void ImprimirInfoProyecto() 
        {
            Console.WriteLine
                        ("Proyecto: {0} {1} {2}", 
                        this.Nombre, 
                        this.descripcion, 
                        this.status);
                        
           Costo c = new Costo ();
            
           Console.WriteLine
                        ("El costo total del proyecto {0} es: $ {1}", 
                        
                        this.nombre,
                        c.CostoTotalProyecto(this)
                        
                        );
                        
        }


    }

}
