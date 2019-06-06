using System;

namespace RazorPagesIgnis 
{
    public class Solicitud : IGestionHoras, IGestionTecnicos
    {
        /// Implementamos DIP y ISP agregando las interfases IGestionHoras y IGestionTecnicos.
        /// Esta abstracciones nos permiten separar las dependencias de otras clases con esta clase.
        /// De acuerdo a ISP, encontramos dos responsabilidades diferentes:
        /// - Agregar o Restar Horas.
        /// - Asignar un técnico.
        /// Son dos conjuntos de tipos diferentes, por lo que separamos:
        /// IGestionHoras: contiene los tipos que manejan las operaciones con horas.
        /// IGestionTecnicos: contiene los tipos que manejan las operaciones con técnicos.
        /// Por ejemplo, una clase que requiera que se agreguen o resten horas no necesita los tipos que manejan tecnicos.
        /// De esta forma los separamos y solo le asignamos la interfase que necesita para su uso.

        public Solicitud() 
        {
            /// Constructor sin argumentos y PrimaryKey para RazorPages.
        }

        public int ID { get; set; }

        public Solicitud(string Solicitud_Rol, string Solicitud_Experiencia, string Solicitud_Obs) 
        {
            this.solicita_rol = Solicitud_Rol;
            this.solicita_experiencia = Solicitud_Experiencia;
            this.solicita_obs = Solicitud_Obs;
            this.tecnicoAsignado = null;
            this.HorasRealizadas = 0;
        }
        
        private string solicita_rol;
        public string Solicitud_Rol 
        {
            get => this.solicita_rol;
            set => this.solicita_rol = value;
        }

        private string solicita_experiencia;
        public string Solicitud_Experiencia 
        {
            get => this.solicita_experiencia;
            set => this.solicita_experiencia = value;
        }

        private string solicita_obs;
        public string Solicitud_Obs  
        {
            get => this.solicita_obs;
            set => this.solicita_obs = value;
        }

        private Tecnico tecnicoAsignado;
        public Tecnico TecnicoAsignado 
        {
            get => this.tecnicoAsignado;
            protected set {}
        }

        public void AsignarTecnico(Tecnico Tecn) 
        {
            Check.Precondicion(!string.IsNullOrEmpty(Tecn.ToString()), "El técnico no puede ser null o vacío.");

            this.tecnicoAsignado = Tecn;
        }

        private int horasRealizadas;
        public int HorasRealizadas 
        {
            get => this.horasRealizadas;
            protected set {}
        }

        public void AgregarHoras(int Horas) 
        {
            Check.Precondicion(Horas > 0, "");

            this.horasRealizadas = this.horasRealizadas + Horas;
        }

        public void RestarHoras(int Horas) 
        {
            Check.Precondicion(Horas > 0, "");

            this.horasRealizadas = this.horasRealizadas - Horas;
        }

    }
}