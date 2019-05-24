using System;

namespace Ignis
{
    public class Cliente : Persona
    {
        /// <summary>
        /// El Cliente es la persona que se registra en la aplicación para postular sus proyectos, también podrá dar de alta una o más solicitudes de técnicos.
        
        /// La clase Cliente hereda todos los atributos y comportamientos de la clase Persona y de la clase Proyecto.
        /// </summary>
        public Cliente (string Nombre, string Correo, string Contrasena) 
                : base(Nombre, Correo, Contrasena)
                {
                    
                } 
    }
}