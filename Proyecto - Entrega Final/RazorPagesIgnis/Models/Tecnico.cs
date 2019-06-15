using System;

using RazorPagesIgnis.Areas.Identity.Data;

namespace RazorPagesIgnis
{ 
    /// <summary>
    /// El Técnico se registra en el Centro Ignis para ser contratado.
    /// </summary>
    public class Tecnico : ApplicationUser
    { 
        /// <summary>
        /// RazorPages: constructor sin argumentos.
        /// </summary>
        public Tecnico() : base() {}

        // /// <summary>
        // /// RazorPages: atributo PrimaryKey.
        // /// </summary>
        // public int ID { get; set; }  

        public Tecnico(string Presentacion, string NivelExperiencia)
        { 
            this.presentacion = Presentacion;                 // Texto de presentación de sí mismo.
            this.nivelExperiencia = NivelExperiencia;       // 'Básico', 'Avanzado'.
        }

        /// <summary>
        /// Presentación: puede incluir un texto para describir su forma de trabajo o habilidades.
        /// </summary>
        private string presentacion;
        public string  Presentacion
        {
            get => this.presentacion;
            set => this.presentacion = value;
        }

        /// <summary>
        /// Nivel de Experiencia que se adjudica el técnico.
        /// </summary>
        /// <value>"Básico", "Avanzado"</value>
        private string nivelExperiencia;
        public string  NivelExperiencia
        {
            get { return this.nivelExperiencia; }
            set { 
                Check.Precondicion((value == "Básico" || value == "Avanzado"), "Nivel de experiencia no admitido.");

                this.nivelExperiencia = value;

                Check.Postcondicion((value == "Básico" || value == "Avanzado"), "Nivel de experiencia no fue actualizado.");
                }
        }

    }
}
