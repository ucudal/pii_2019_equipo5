using System;

namespace Ignis
{   
    public class Administrador : Persona 
    { 
        /// Constructor sin argumentos y PrimaryKey para RazorPages.
        public Administrador() 
        {

        }

        public new int ID { get; set; }   // se agrega 'new' para evitar advertencia de compilación.

        public Administrador(string Nombre, string Correo, string Contrasena) 
                    : base(Nombre, Correo, Contrasena) 
        { 
            /// Nombre, correo y contraseña: se chequea precondiciones en la clase Persona.
        }

    }
}