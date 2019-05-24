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
                        string presentacion, string nivel_experiencia, 
                        int calif_Clientes, int calif_Ignis) 
                    : base(Nombre, Correo, Contrasena) 
        { 
            Check.Precondicion(!string.IsNullOrEmpty(Edad.ToString()), "La edad no puede ser nulo o vacío.");
            Check.Precondicion((Edad > 0), "La edad debe ser mayor que cero.");

            this.edad = Edad;
            this.presentacion = "";         // Texto de presentación de sí mismo.
            this.nivel_experiencia = "";    // 'Básico', 'Avanzado'.
            this.calif_Clientes = 0;        // Rango del 0 al 5.
            this.calif_Ignis = 0;           // Rango del 0 al 5.
        }

        /// <summary>
        /// Edad. 
        /// 
        /// La edad debe ser mayor a cero, no puede ser nulo o vacío. 
        /// </summary>
        private Int32 edad;
        public Int32 Edad 
        {
            get 
            { 
                return edad; 
            }
            set 
            { 
                Check.Precondicion(!string.IsNullOrEmpty(Edad.ToString()), "La edad no puede ser nulo o vacío.");
                Check.Precondicion((Edad > 0), "La edad debe ser mayor que cero.");

                this.edad = value;

                Check.Postcondicion(this.Edad == value, "Edad no fue actualizado.");
            }
        }

        /// <summary>
        /// Presentación
        /// 
        /// El técnico puede incluir un texto para aclarar cosas, describir su forma de trabajo o intéreses.
        /// </summary>
        private string presentacion { get; set; }
        public string  Presentacion
        {
            get => this.presentacion;
            set => this.presentacion = Presentacion;
        }

        /// <summary>
        /// Nivel de Experiencia
        /// 
        /// Nivel que el técnico se adjudica de experiencia.
        /// </summary>
        /// <value>"Básico", "Avanzado"</value>
        private string nivel_experiencia { get; set; }
        public string  Nivel_experiencia
        {
            get => this.nivel_experiencia;
            set => this.nivel_experiencia = Nivel_experiencia;
        }

        /// <summary>
        /// Calificación promedio de los clientes.
        /// </summary>
        /// <value>Rango: 0 al 5, siendo 5 la mejor calificación.</value>
        private int calif_Clientes { get; set; }
        public int  Calif_Clientes
        {
            get => this.calif_Clientes;
            set => this.calif_Clientes = value;
        }

        /// <summary>
        /// Calificación del Centro Ignis.
        /// </summary>
        /// <value>Rango: 0 al 5, siendo 5 la mejor calificación.</value>
        private int calif_Ignis { get; set; }
        public int Calif_Ignis
        {
            get => this.calif_Ignis;
            set => this.calif_Ignis = value;
        }

        // /// <summary>
        // /// Método para modificar la calificación de clientes.
        // /// 
        // /// Esta calificación es un promedio, ya que se considera la calificación 
        // /// que el técnico tenía de otros usuarios antes de agregarse una nueva.
        // /// </summary>
        // /// <value>Rango: 0 al 5, siendo 5 la mejor calificación.</value>
        // public void modificarCalif_Clientes(int nuevaCalificacion) 
        // {
        //     Check.Precondicion((nuevaCalificacion >= 0 && nuevaCalificacion <= 5) , "El rango debe estar entre 0 y 5.");

        //     if (nuevaCalificacion == 0) this.calificacionClientes == 
        // }

    }
}
