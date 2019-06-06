using System;

namespace RazorPagesIgnis
{   
    public class Administrador : Persona 
    { 
        /// <summary>
        /// El Administrador es la persona que trabaja en el Centro Ignis.
        /// 
        /// Los campos obligatorios son: nombre y edad.
        /// Nombre, correo y contraseña los valida la clase Persona.
        /// </summary>
        public Administrador(string nombre, string correo, string contrasena) 
                    : base(nombre, correo, contrasena) 
        { 
        }

        /// Para RazorPages: constructor sin argumentos, atributo ID es PrimaryKey para la base.
        /// Para el atributo se agrega parámetro 'new' por advertencia de compilación.
        public Administrador() 
        {
        }

        public new int ID { get; set; }   

    }
}
