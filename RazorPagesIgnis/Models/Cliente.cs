using System;

namespace RazorPagesIgnis
{   
    public class Cliente : Persona 
    {
        /// <summary>
        /// El cliente es la persona que tiene el proyecto y contrata los servicios del técnico.
        /// 
        /// Nombre, correo y contraseña: se chequean en la clase Persona.
        /// </summary>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="correo">Correo electrónico</param>
        /// <param name="contrasena">Contraseña</param>        
        public Cliente(string nombre, string correo, string contrasena) 
                    : base(nombre, correo, contrasena) 
        { 
        }

        /// Para RazorPages: constructor sin argumentos, atributo ID es PrimaryKey para la base.
        /// Para el atributo se agrega parámetro 'new' por advertencia de compilación.
        public Cliente() 
        {
        }

        public new int ID { get; set; }

    }
}
