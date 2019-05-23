using System;

namespace Ignis
{   
    public class Tecnico : Persona
    {
        /// <summary>
        /// El Técnico es la persona que se registra en la aplicación para ser contratado.
        /// Puede anotarse hasta en 3 roles (especialidades) y los Administradores lo asigna a Proyectos.
        /// 
        /// La clase Tecnico hereda todos los atributos y comportamientos de la clase Persona.
        /// </summary>
        public Tecnico(string Nombre, string Correo, string Contrasena, Int32 Edad) 
                        : base(Nombre, Correo, Contrasena) 
        {
            this.edad = Edad;
        }


        /// <summary>
        /// Atributo: Edad. 
        /// Validación: la edad debe ser mayor a cero, no puede ser nulo o vacío. 
        /// Este parámetro puede ser cambiado por el Administrador, ya que podria especificar una edad 
        /// mínima de contratación de técnicos (ejem. 18 años).
        /// </summary>
        private Int32 edad;
        public Int32 Edad 
        {
            get { return edad; }
            set 
            { 

                if ( string.IsNullOrEmpty(value.ToString()) && (value > 0) ) 
                {
                    Console.WriteLine("Error. No puede ingresar un valor nulo o vacío. El valor debe ser mayor a cero.");
                }
                else 
                {
                    this.edad = value;
                }
            }
        }

    }
}
