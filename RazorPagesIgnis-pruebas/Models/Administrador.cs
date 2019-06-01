using System;

namespace Ignis
{   
    public class Administrador : Persona 
    { 
        /// Constructor sin argumentos y PrimaryKey para RazorPages.
        public Administrador() 
        {

        }

        public int ID { get; set; }

        public Administrador(string Nombre, string Correo, string Contrasena) 
                    : base(Nombre, Correo, Contrasena) 
        { 
            /// Nombre, correo y contraseña: se chequea precondiciones en la clase Persona.
        }

    }
}