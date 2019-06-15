using System;

namespace RazorPagesIgnis 
{
    /// <summary>
    /// Rol del técnico.
    /// </summary>
    public class Rol : IRol
    {
        /// <summary>
        /// RazorPages: constructor sin argumentos.
        /// </summary>
        public Rol()
        {

        }

        /// <summary>
        /// RazorPages: atributo PrimaryKey.
        /// </summary>
        public int Id { get; set; }  

        /// <summary>
        /// Rol del técnico.
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Descripcion"></param>
        public Rol(string Nombre, string Descripcion) 
        {
            this.nombre = Nombre;
            this.descripcion = Descripcion;
        }

        /// <summary>
        /// Nombre del rol.
        /// </summary>
        private string nombre;
        public string Nombre  
        { 
            get => this.nombre; 
            set => this.nombre = value;
        }

        /// <summary>
        /// Descripción del rol (opcional).
        /// </summary>
        private string descripcion;
        public string Descripcion  
        { 
            get => this.descripcion; 
            set => this.descripcion = value;
        }
        
        // Modificar nombre del rol.
        public void ModificarNombre(string Nombre) 
        {
            this.nombre = Nombre;
        }

        // Modificar descripción del rol.
        public void ModificarDescripcion(string Descripcion) 
        {
            this.descripcion = Descripcion;
        }

    }    
}
