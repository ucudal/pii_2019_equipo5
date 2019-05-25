using System;
using System.Collections.Generic;

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
        public Tecnico(string Nombre, string Correo, string Contrasena, Int32 Edad, string presentacion, 
                        string nivel_experiencia, int calif_Clientes, int calif_Ignis, List<int> ListaCalif_Clientes) 
                    : base(Nombre, Correo, Contrasena) 
        { 
            Check.Precondicion(!string.IsNullOrEmpty(Edad.ToString()), "La edad no puede ser nulo o vacío.");
            Check.Precondicion((Edad > 0), "La edad debe ser mayor que cero.");

            this.edad = Edad;
            this.presentacion = "";                 // Texto de presentación de sí mismo.
            this.nivel_experiencia = "";            // 'Básico', 'Avanzado'.
            this.calif_Clientes = 0;                // Rango del 0 al 5.
            this.calif_Ignis = 0;                   // Rango del 0 al 5.
            this.listaCalif_Clientes = ListaCalif_Clientes; 
        }

        /// <summary>
        /// Edad. 
        /// 
        /// La edad debe ser mayor a cero, no puede ser nulo o vacío. 
        /// </summary>
        private Int32 edad;
        public Int32 Edad 
        {
            get { return this.edad; }
            set { 
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
        private string presentacion;
        public string  Presentacion
        {
            get => this.presentacion;
            set => this.presentacion = value;
        }

        /// <summary>
        /// Nivel de Experiencia
        /// 
        /// Nivel que el técnico se adjudica de experiencia.
        /// </summary>
        /// <value>"Básico", "Avanzado"</value>
        private string nivel_experiencia;
        public string  Nivel_experiencia
        {
            get { return this.nivel_experiencia; }
            set { 
                Check.Precondicion((value == "Básico" || value == "Avanzado"), "Nivel de experiencia no admitido.");

                this.nivel_experiencia = value;

                Check.Postcondicion((value == "Básico" || value == "Avanzado"), "Nivel de experiencia no fue actualizado.");
                }
        }

        /// <summary>
        /// Calificación promedio de los clientes.
        /// </summary>
        /// <value>Rango: 0 al 5, siendo 5 la mejor calificación.</value>
        private int calif_Clientes;
        public int Calif_Clientes
        {
            get { return this.calif_Clientes; }
            set { 
                Check.Precondicion((value >= 0 && value <= 5), "Calificación Cliente fuera de rango.");

                this.calif_Clientes = value;

                Check.Postcondicion((this.calif_Clientes >= 0 && this.calif_Clientes <= 5), "Calificación Cliente fuera de rango.");
                }
        }



        public void ActualizarCalif_Clientes() //int Calif, List<int> Lista_Calif_Clientes) 
        {
            IList<int> listaCalif = new List<int>() {4};

            int Calif = 2;

            double suma = 0;

            for (int i = 0; i < listaCalif.Count; i++)  
            {
                suma = suma + listaCalif[i];
            }

            this.Calif_Clientes = Convert.ToInt32(Math.Round(suma / listaCalif.Count));
        }

        /// <summary>
        /// Lista de calificaciones que ha recibido el técnico por parte de clientes.
        /// </summary>
        private List<int> listaCalif_Clientes;
        public List<int> ListaCalif_Clientes
        {
            get => this.listaCalif_Clientes;
            set => this.listaCalif_Clientes = value;
        }

        /// <summary>
        /// Calificación del Centro Ignis.
        /// </summary>
        /// <value>Rango: 0 al 5, siendo 5 la mejor calificación.</value>
        private int calif_Ignis;
        public int Calif_Ignis
        {
            get { return this.calif_Ignis; }
            set { 
                Check.Precondicion((value >= 0 && value <= 5), "Calificación Cliente fuera de rango.");

                this.calif_Ignis = value;

                Check.Postcondicion((this.calif_Ignis >= 0 && this.calif_Ignis <= 5), "Calificación Cliente fuera de rango.");
                }
        }

    }
}
