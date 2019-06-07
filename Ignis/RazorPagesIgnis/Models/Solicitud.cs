using System;

namespace RazorPagesIgnis 
{
    public class Solicitud : IGestionHoras, IGestionTecnicos
    {
        public Solicitud(int ModoDeContrato, string RolRequerido, int HorasContratadas, string NivelExperiencia, string Observaciones) 
        {
            this.modoDeContrato = ModoDeContrato;
            this.rolRequerido = RolRequerido;
            this.horasContratadas = HorasContratadas;
            this.nivelExperiencia = NivelExperiencia;
            this.observaciones = Observaciones;

            // ICosto Costo = new ICosto();
            // this.costoSolicitud = 1000; // - - - - - > Costo.CostoTotalProyecto(ModoDeContrato, HorasContratadas, NivelExperiencia);

            this.tecnicoAsignado = null;
        }

        // Modo de Contratación
        // 1: horas y 2: Jornada.
        private int modoDeContrato;
        public int ModoDeContrato 
        {
            get => this.modoDeContrato;
            set => this.modoDeContrato = value;
        }

        // Es el rol que se está necesitando.
        private string rolRequerido;
        public string RolRequerido 
        {
            get => this.rolRequerido;
            set => this.rolRequerido = value;
        }

        // Registro de las horas contratadas por cliente.
        private int horasContratadas;
        public int HorasContratadas 
        {
            get => this.horasContratadas;
            protected set {}
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

        // Costo de la solicitud.
        private int costoSolicitud;
        public int CostoSolicitud 
        {
            get => this.costoSolicitud;
            protected set {}

        }

        // Método para asignar un técnico a esta solicitud.
        public void AsignarTecnico(Tecnico Tecnico) 
        {
            Check.Precondicion(!string.IsNullOrEmpty(Tecnico.ToString()), "El técnico no puede ser null o vacío.");

            this.tecnicoAsignado = Tecnico;
        }

        // Método para agregar horas de contratación.
        // El mensaje recibido debe tener como parámetro un valor positivo.
        // Implementamos valor absoluto sobre la variable para evitar error en el cálculo.
        public void AgregarHoras(int Horas) 
        {
            Check.Precondicion(Math.Abs(Horas) > 0, "El valor debe ser mayor a cero.");

            this.horasContratadas += Math.Abs(Horas);

            // Actualizamos el costo de esta solicitud.
            this.ActualizarCostoSolicitud();
        }

        // Método para restar horas de contratación.
        // El mensaje recibido debe tener como parámetro un valor positivo.
        // Implementamos valor absoluto sobre la variable para evitar error en el cálculo.
        public void RestarHoras(int Horas) 
        {
            Check.Precondicion(Math.Abs(Horas) > 0, "El valor debe ser mayor a cero.");
            Check.Precondicion((this.horasContratadas - Math.Abs(Horas)) >= 0, "El resultado no puede ser negativo.");

            if ((this.horasContratadas  - Math.Abs(Horas)) >= 0) this.horasContratadas -= Math.Abs(Horas);

            // Actualizamos el costo de esta solicitud.
            this.ActualizarCostoSolicitud();
        }

        /// Este método actualiza el costo estipulado para la solicitud.
        /// Se ejecuta en dos oportunidades: cuando se agregan / restan horas y cuando se actualizan los precios.
        public void ActualizarCostoSolicitud() 
        {
            // ICosto Costo = new Costo(); 
            // this.costoSolicitud = 1000; // - - - - - > Costo.CostoTotalProyecto(this.ModoDeContrato, this.HorasContratadas, this.NivelExperiencia);
        }

        /// Para RazorPages: constructor sin argumentos, atributo ID es PrimaryKey para la base.
        public Solicitud() 
        {
        }

        public int ID { get; set; }

    }
}