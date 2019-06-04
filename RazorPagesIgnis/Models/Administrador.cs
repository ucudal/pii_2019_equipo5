using System;

namespace Ignis
{   
    public class Administrador : Persona 
    { 
        public Administrador() 
        {
            /// Constructor sin argumentos y PrimaryKey para RazorPages.
        }

        public new int ID { get; set; }   // se agrega 'new' para evitar advertencia de compilación.

        /// <summary>
        /// El Administrador es la persona que trabaja en el Centro Ignis.
        /// Asigna técnicos a proyectos, hace el seguimiento de los proyectos, los técnicos y los clientes.
        /// Puede activar / inactivar clientes y técnicos.
        /// 
        /// La clase Administrador hereda todos los atributos y comportamientos de la clase Persona.
        /// Los campos obligatorios son: nombre y edad.
        /// </summary>
        public Administrador(string Nombre, string Correo, string Contrasena) 
                    : base(Nombre, Correo, Contrasena) 
        { 
            // Nombre, correo y contraseña los valida la clase Persona.
        }

    }
}