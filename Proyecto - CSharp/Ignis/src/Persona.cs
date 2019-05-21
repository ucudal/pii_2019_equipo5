using System;

namespace Ignis 
{   
    public class Persona 
    {
        /// <summary>
        /// La clase Persona es superclase de las clases Cliente, Técnico y Administrador.
        /// Considerando la propiedad polimórfica, implementamos herencia porque todas 
        /// estas clases utilizan todos sus atríbutos y comportamientos.
        /// 
        /// A los efectos de encapsulamiento implementamos getters y setters, que además 
        /// nos permitió validar el ingreso de valores.
        /// </summary>
        public Persona(string Nombre, string Correo, string Contrasena) 
        {
            this.nombre = Nombre;
            this.correo = Correo;
            this.contrasena = Contrasena;
            this.status = statusAux.Valor;
        }


        /// <summary>
        /// Atributo: Nombre.
        /// En SET validamos que no se ingresen valores nulo o vacío.
        /// </summary>
        private string nombre { get; set; }
        public string Nombre 
        {
            get 
            { 
                return this.nombre; 
            }
            set 
            { 
                if ( string.IsNullOrWhiteSpace(value) )
                    throw new ArgumentException("No se puede ingresar un valor nulo o vacío.");
                
                this.nombre = value;
            }
        }


        /// <summary>
        /// Atributo: Correo.
        /// En SET validamos que la dirección tenga formato de correo.
        /// </summary>
        private string correo { get; set; }
        public string Correo 
        {
            get 
            { 
                return this.correo; 
            }
            set 
            {
                /// Controlamos que el valor ingresado tenga formato de dirección de correo electrónico.
                this.correo = value; 
            }
        }


        /// <summary>
        /// Atributo: Contraseña.
        /// </summary>
        private string contrasena { get; set; }
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
        private bool status { get; set; }
        public bool Status 
        {
            get => status;
            set => this.status = value;
        }

        private Status statusAux = new Status(true);

    }
}
