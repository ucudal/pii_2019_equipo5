using System;

namespace Ignis
{   
    public class Persona 
    {
        /// <summary>
        /// Constructor de la clase Persona.
        /// </summary>
        public Persona(string Nombre, string Correo, string Contrasena) 
        {
            this.nombre = Nombre;
            this.correo = Correo;
            this.contrasena = Contrasena;
            this.estado = true;             // True = activo.
        }

        /// <summary>
        /// Atributo Nombre. 
        /// Controlamos que no sea nulo o vacío el valor ingresado.
        /// </summary>
        private string nombre;
        public string Nombre 
        {
            get { return nombre; }
            set 
            { 
                if (string.IsNullOrEmpty(value)) 
                {
                    Console.WriteLine("Se ingresó un valor nulo o vacío.");
                }
                else 
                {
                    this.nombre = value;
                }
            }
        }

        /// <summary>
        /// Atributo Correo.
        /// Controlamos que los valores ingresados tengan formato de correo.
        /// Debe tener una arroba y un dominio.
        /// </summary>
        private string correo;
        public string Correo 
        {
            get { return correo; }
            set 
            {
                this.correo = value; 
            }
        }

        /// <summary>
        /// Atributo Contraseña.
        /// </summary>
        private string contrasena;
        public string Contrasena  
        {
            get { return contrasena; }
            set 
            {
                this.CambiarContrasena(value);
            }
        }

        /// <summary>
        /// Método para el cambio de contraseña.
        /// Controlamos que no sea nula y que tenga un largo mínimo de cuatro carácteres.
        /// </summary> 
        private void CambiarContrasena(string value) 
        {
            if ( (string.IsNullOrEmpty(value)) && (value.Length < 4) ) 
            {
                Console.WriteLine("Se ingresó un valor que no cumple con los requisitos. Debe tener un largo mayor a 4 carácteres, no puede ser nulo o vacío.");
            }
            else 
            {
                this.contrasena = value; 
            }
        }

        /// <summary>
        /// Atributo Estado.
        /// </summary>
        private bool estado;
        public bool Estado 
        { 
            get { return this.estado; }
            private set{} 
        }

        /// <summary>
        /// Método para cambiar el atributo Estado.
        /// </summary>
        private void CambiarEstado() 
        {
            this.estado = !estado;
        }

        /// <summary>
        /// Método para activar una persona.
        /// </summary>
        public void Activar() 
        {
            if (this.estado == false) 
            {
                this.CambiarEstado();
            }
            else 
            {
                Console.WriteLine("Error, el cliente se encuentra activo.");
            }
        }

        /// <summary>
        /// Método para desactivar una persona.
        /// </summary>
        public void Desactivar() 
        {
            if (this.estado == true) 
            {
                this.CambiarEstado();
            }
            else 
            {
                Console.WriteLine("Error, el cliente se encuentra desactivado.");
            }
        }
    }
}
