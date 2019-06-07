using System;
using System.Collections.Generic;

namespace RazorPagesIgnis 
{   
    public class Proyecto : ICrearSolicitud 
    { 
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
        /// <param name="nuevaSolicitud">La nueva solicitud creada que se agrega a la lista</param>
        public void AgregarSolicitud(Solicitud nuevaSolicitud) 
        {
            ListaDeSolicitudes.Add(nuevaSolicitud);
        }

        /// <summary>
        /// Este método imprime por pantalla el costo total del proyecto.
        /// </summary>
        public void ImprimirCostoTotal() 
        {
            IConsoleWriter Consola = new ConsoleWriter();

            Consola.ImprimirCostoTotalDelProyecto(this);
        }

        /// <summary>
        /// Métodos para cambiar el status.
        /// Activar(): si el proyecto está 'Cerrado' se cambia para 'Activo'.
        /// Cerrar(): si el proyecto está 'Activo' se cambia para 'Cerrado'.
        /// </summary>
        public void Activar() 
        {
            if (this.status == false) this.CambiarStatus();
        }

        public void Cerrar() 
        {
            if (this.status == true) this.CambiarStatus();
        }

        private void CambiarStatus() 
        {
            this.status = !this.status;
        }

        /// Para RazorPages: constructor sin argumentos, atributo ID es PrimaryKey para la base.
        public Proyecto() 
        {
        }

        public int ID { get; set; }

    }
}
