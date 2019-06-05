using System;

namespace RazorPagesIgnis
{   
    public class Administrador : Persona 
    { 
        public Administrador() 
        {
            /// Constructor sin argumentos y PrimaryKey ID para RazorPages.
        }

        public new int ID { get; set; }   // se agrega 'new' para evitar advertencia de compilación.

        /// <summary>
        /// El Administrador es la persona que trabaja en el Centro Ignis.
        /// 
        /// Los campos obligatorios son: nombre y edad.
        /// </summary>
        public Administrador(string Nombre, string Correo, string Contrasena) 
                    : base(Nombre, Correo, Contrasena) 
        { 
            // Nombre, correo y contraseña los valida la clase Persona.
        }

    }
}