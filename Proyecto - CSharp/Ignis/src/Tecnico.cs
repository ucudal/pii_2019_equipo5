using System;

namespace Ignis
{   
    public class Tecnico : Persona
    {
        /// <summary>
        /// El TECNICO es la persona que se registra en el sistema para ser contratado.
        /// Esta clase es subclase de Persona, para utilizar todos sus atributos y comportamientos.
        /// </summary>
        public Tecnico(string Nombre, string Correo, string Contrasena, Int32 Edad) 
                        : base(Nombre, Correo, Contrasena) 
        {
            this.edad = Edad;
        }


        /// <summary>
        /// Atributo: Edad. 
        /// </summary>
        private Int32 edad;
        public Int32 Edad 
        {
            get { return edad; }
            set 
            { 
                /// El valor debe ser mayor a cero. 
                /// Controlamos que no sea nulo o vacío el valor ingresado.
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
