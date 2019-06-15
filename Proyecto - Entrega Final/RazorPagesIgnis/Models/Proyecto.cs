using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesIgnis 
{   
    public class Proyecto : ICrearSolicitud
    { 
        /// <summary>
        /// RazorPages: constructor sin argumentos.
        /// </summary>
        public Proyecto()
        {
        }

        /// <summary>
        /// RazorPages: atributo PrimaryKey.
        /// </summary>
        [Key]
        public int Id { get; set; }  

        /// <summary>
        /// Proyecto ingresado por el cliente.
        /// </summary>
        public Proyecto(string Nombre, string Descripcion) 
        {
            this.nombre = Nombre;
            this.descripcion = Descripcion;
            this.status = true;
        }

        /// <summary>
        /// Nombre del proyecto.
        /// </summary>
        private string nombre;
        public string Nombre  
        { 
            get => this.nombre; 
            set => this.nombre = value;
        }

        /// <summary>
        /// Descripción del proyecto.
        /// </summary>
        private string descripcion;
        public string Descripcion  
        { 
            get => this.descripcion; 
            set => this.descripcion = value;
        }

        /// <summary>
        /// Estado del proyecto.
        /// </summary>
        private bool status;
        public bool Status 
        {
            get => this.status;
            protected set {}
        }

        /// <summary>
        /// Relación Cliente:Proyectos (uno-a-muchos)
        /// </summary>
        public int ClienteId { get; set; }

        /// </summary>
        /// Relación Proyecto:Solicitudes (uno-a-muchos)
        /// </summary>
        public IList<Solicitud> Solicitud { get; set; }

        /// <summary>
        /// Agregar solicitud al registro de solicitudes de este proyecto.
        /// </summary>
        /// <param name="nuevaSolicitud"></param>
        public void AgregarSolicitud(Solicitud nuevaSolicitud) 
        {
            Solicitud.Add(nuevaSolicitud);
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
            if (this.status == true) 
            {
                this.CambiarStatus();

                /// Cuando cerramos el proyecto, se cierran todas sus solicitudes.
                foreach (Solicitud item in this.Solicitud)
                {
                    item.Cerrar();
                }
            }
        }

        private void CambiarStatus() 
        {
            this.status = !this.status;
        }

    }
}
        // /// <summary>
        // /// Este método retorna el costo total del proyecto.
        // /// </summary>
        // public int InformarCostoTotalProyecto() 
        // {
        //     int CostoTotal = 0;
            
        //     foreach (Solicitud item in listaSolicitudes) 
        //     {
        //         CostoTotal += item.CostoSolicitud;
        //     }
            
        //     return CostoTotal;
        // }
