using System;

namespace RazorPagesIgnis 
{
    public class Solicitud : IGestionHoras, IGestionTecnicos
    {
        /// <summary>
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
        /// </summary>
        public Solicitud(string RolRequerido, string NivelExperiencia, string Observaciones) 
        {
            this.rolRequerido = RolRequerido;
            this.nivelExperiencia = NivelExperiencia;
            this.observaciones = Observaciones;

            this.tecnicoAsignado = null;
            this.HorasRealizadas = 0;
        }

        // Es el rol que se está necesitando.
        private string rolRequerido;
        public string RolRequerido 
        {
            get => this.rolRequerido;
            set => this.rolRequerido = value;
        }

        // Es el nivel de esperiencia que se necesita (Básico, Avanzado).
        private string nivelExperiencia;
        public string NivelExperiencia 
        {
            get => this.nivelExperiencia;
            set => this.nivelExperiencia = value;
        }

        // Observaciones de la solicitud (opcional).
        private string observaciones;
        public string Observaciones  
        {
            get => this.observaciones;
            set => this.observaciones = value;
        }

        // La solicitud conoce el técnico cuando se le asigna.
        private Tecnico tecnicoAsignado;
        public Tecnico TecnicoAsignado 
        {
            get => this.tecnicoAsignado;
            protected set {}
        }

        // Método para asignar un técnico a esta solicitud.
        public void AsignarTecnico(Tecnico Tecnico) 
        {
            Check.Precondicion(!string.IsNullOrEmpty(Tecnico.ToString()), "El técnico no puede ser null o vacío.");

            this.tecnicoAsignado = Tecnico;
        }

        // Registro de las horas realizadas por el técnico asignado a esta solicitud.
        private int horasRealizadas;
        public int HorasRealizadas 
        {
            get => this.horasRealizadas;
            protected set {}
        }

        // Método para agregar horas al técnico asignado.
        // El mensaje recibido debe tener como parámetro un valor positivo.
        // Implementamos valor absoluto sobre la variable para evitar error en el cálculo.
        public void AgregarHoras(int Horas) 
        {
            Check.Precondicion(Math.Abs(Horas) > 0, "El valor debe ser mayor a cero.");

            this.horasRealizadas += Math.Abs(Horas);
        }

        // Método para restar horas al técnico asignado.
        // El mensaje recibido debe tener como parámetro un valor positivo.
        // Implementamos valor absoluto sobre la variable para evitar error en el cálculo.
        public void RestarHoras(int Horas) 
        {
            Check.Precondicion(Math.Abs(Horas) > 0, "El valor debe ser mayor a cero.");
            Check.Precondicion((this.horasRealizadas - Math.Abs(Horas)) >= 0, "El resultado no puede ser negativo.");

            if ((this.horasRealizadas - Math.Abs(Horas)) >= 0) this.horasRealizadas -= Math.Abs(Horas);
        }

        /// Para RazorPages: constructor sin argumentos, atributo ID es PrimaryKey para la base.
        public Solicitud() 
        {
        }

        public int ID { get; set; }

    }
}