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
        public Tecnico(string Nombre, string Correo, string Contrasena, Int32 Edad, 
                        string presentacion, string condAcademica, int anioEgreso, 
                        string nivel_experiencia, int calificacionClientes, int calificacionIgnis) 
                : base(Nombre, Correo, Contrasena) 
        {
            this.edad = Edad;
            this.presentacion = "";         // Texto de presentación de sí mismo.
            this.condAcademica = "";        // 'Estudiante', 'Egresado'.
            this.anioEgreso = 0;
            this.nivel_experiencia = "";    // 'Básico', 'Avanzado'.
            this.calificacionClientes = 0;  // Rango del 0 al 5.
            this.calificacionIgnis = 0;     // Rango del 0 al 5.
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

        private string presentacion { get; set; }
        private string condAcademica { get; set; }
        private int anioEgreso { get; set; } 
        private string nivel_experiencia { get; set; }
        private int calificacionClientes { get; set; }
        private int calificacionIgnis { get; set; }

    }
}
