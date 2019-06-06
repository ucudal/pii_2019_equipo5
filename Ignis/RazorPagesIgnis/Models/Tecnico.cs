using System;
using System.Collections.Generic;

namespace RazorPagesIgnis
{   
    public class Tecnico : Persona
    {
        /// Constructor sin argumentos y PrimaryKey ID para RazorPages.
        public Tecnico() 
        {
        }
        
        public new int ID { get; set; }   // se agrega 'new' para evitar advertencia de compilación de RazorPages.

        /// <summary>
        /// El Técnico es la persona que se registra en la aplicación para ser contratado.
        /// Puede anotarse hasta en 3 roles (especialidades) y los Administradores lo asignan a Proyectos.
        /// 
        /// Los campos obligatorios son: nombre y edad.
        /// </summary>
        public Tecnico(string Nombre, string Correo, string Contrasena, 
                        Int32 Edad, string presentacion, string nivel_experiencia) 
                    : base(Nombre, Correo, Contrasena) 
        { 
            // Nombre, correo y contraseña los valida la clase Persona.
            Check.Precondicion(!string.IsNullOrEmpty(Edad.ToString()), "La edad no puede ser nulo o vacío.");
            Check.Precondicion((Edad > 0), "La edad debe ser mayor que cero.");

            this.edad = Edad;
            this.presentacion = "";                 // Texto de presentación de sí mismo.
            this.nivel_experiencia = "";            // 'Básico', 'Avanzado'.
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
                Check.Precondicion(!string.IsNullOrEmpty(value.ToString()), "La edad no puede ser nulo o vacío.");
                Check.Precondicion((value > 0), "La edad debe ser mayor que cero.");

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
        /// Método para cambio de nivel de experiencia.
        /// 
        /// Si actualmente es Básico, lo cambia a Avanzado.
        /// </summary>
        public void cambiarNivelExperienciaAvanzado() 
        {
            if (this.Nivel_experiencia == "Básico") this.Nivel_experiencia = "Avanzado";
        }

    }
}