using System;

namespace Ignis
{   
    public class Cliente : Persona 
    {
        /// Constructor sin argumentos y PrimaryKey para RazorPages.
        public Cliente() 
        {

        }

        public new int ID { get; set; }   // se agrega 'new' para evitar advertencia de compilación.

        /// <summary>
        /// El cliente es la persona que tiene el proyecto y contrata los servicios del técnico.
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Correo"></param>
        /// <param name="Contrasena"></param>        
        public Cliente(string Nombre, string Correo, string Contrasena) 
                    : base(Nombre, Correo, Contrasena) 
        { 
            /// Nombre, correo y contraseña: se chequea precondiciones en la clase Persona.
        }

    }
}
