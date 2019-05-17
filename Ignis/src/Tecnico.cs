using System;

namespace Ignis
{   
    public class Tecnico : Persona
    {
        /// <summary>
        /// Constructor de la clase Persona.
        /// Utilizamos herencia, la clase base es Persona.
        /// </summary>
        public Tecnico(string Nombre, string Correo, string Contrasena, Int32 Edad) 
        : base(Nombre, Correo, Contrasena) 
        {
            this.edad = Edad;
        }

        /// <summary>
        /// Atributo Edad. 
        /// Controlamos que no sea nulo o vacío el valor ingresado.
        /// El valor debe ser mayor a cero.
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
