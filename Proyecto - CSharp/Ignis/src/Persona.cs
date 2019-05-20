using System;

namespace Ignis
{   
    public class Persona 
    {
        /// <summary> 
        /// Esta es Superclase de las clases: Administrador, Cliente y Administrador.
        /// Estas clases heredan todos los atributos y métodos de la clase Persona.
        /// </summary>
        public Persona(string Nombre, string Correo, string Contrasena) 
        {
            this.nombre = Nombre;
            this.correo = Correo;
            this.contrasena = Contrasena;

            Status statusValor = new Status(true);
            this.status = statusValor.Valor;
        }

        /// <summary>
        /// Atributo: Nombre.
        /// </summary>
        private string nombre;
        public string Nombre 
        {
            get { return nombre; }
            set 
            { 
                /// Controlamos que el valor ingresado no sea nulo o vacío.
                if ( string.IsNullOrEmpty(value) ) 
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
        /// Atributo: Correo.
        /// </summary>
        private string correo;
        public string Correo 
        {
            get { return this.correo; }
            set 
            {
                /// Controlamos que el valor ingresado tenga formato de dirección de correo electrónico.
                this.correo = value; 
            }
        }

        /// <summary>
        /// Atributo: Contraseña.
        /// </summary>
        private string contrasena;
        public string Contrasena  
        {
            get { return this.contrasena; }
            set 
            {
                this.CambiarContrasena(value);
            }
        }

        /// <summary>
        /// Método para el cambio de contraseña.
        /// </summary> 
        private void CambiarContrasena(string value) 
        {
            /// Controlamos que el valor ingresado no sea nula y que tenga un largo mínimo de cuatro carácteres.
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
        /// Atributo: Status.
        /// </summary>
        public bool status  
        {
            get { return this.status; }
            private set {}
        }
    }
}
