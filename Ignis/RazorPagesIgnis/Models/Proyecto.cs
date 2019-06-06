using System;
using System.Collections.Generic;

namespace RazorPagesIgnis 
{   
    public class Proyecto
    {
        /// Constructor sin argumentos y PrimaryKey ID para RazorPages.
        public Proyecto() 
        {
        }

        public int ID { get; set; }

        public Proyecto(string Nombre, string Descripcion) 
        {
            this.nombre = Nombre;
            this.descripcion = Descripcion;
            this.status = true;

            List<Solicitud> ListaDeSolicitudes = new List<Solicitud>();
            this.listaSolicitudes = ListaDeSolicitudes;
        }

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

        /// <summary>
        /// Este método agrega una nueva solicitud a la lista de solicitudes del proyecto.
        /// </summary>
        /// <param name="nuevaSolicitud">la nueva solicitud creada que se agrega a la lista</param>
        public void agregarSolicitud(Solicitud nuevaSolicitud) 
        {
            ListaDeSolicitudes.Add(nuevaSolicitud);
        }

        /// <summary>
        /// Este método imprime por pantalla el costo total del proyecto.
        /// </summary>
        public void imprimirInfoCostoTotal() 
        {
            IConsoleWriter iconsole = new ConsoleWriter();

            iconsole.imprimirCostoTotalProyecto(this);
        }

    }

}
