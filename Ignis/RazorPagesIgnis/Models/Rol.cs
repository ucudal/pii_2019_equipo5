using System;

namespace RazorPagesIgnis 
{
    public class Rol : IRol
    {
        /// Constructor sin argumentos y PrimaryKey ID para RazorPages.
        public Rol() 
        {
        }

        public int ID { get; set; }

        /// <summary>
        /// El Rol corresponde a un profesión técnica.
        /// </summary>
        public Rol(string Nombre, string Descripción) 
        {
            this.nombre = Nombre;
            this.descri = Descripción;
        }

        // Nombre del rol.
        private string nombre;
        public string Nombre 
        {
            get => this.nombre;
            protected set {}        // => this.nombre = value;
        }

        // Descripción del rol (opcional).
        private string descri;
        public string Descripcion 
        {
            get => this.descri;
            protected set {}        // => this.descri = value;
        }
        
        // Modificar nombre del rol.
        public void modificarNombre(string Nombre) 
        {
            this.Nombre = Nombre;
        }

        // Modificar descripción del rol.
        public void modificarDescripcion(string Descripcion) 
        {
            this.Nombre = Descripcion;
        }

    }    
}
