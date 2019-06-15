using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesIgnis 
{
    public class Solicitud : IGestionHoras, IObserverCosto
    {
        /// <summary>
        /// RazorPages: constructor sin argumentos.
        /// </summary>
        public Solicitud()
        {
        }

        /// <summary>
        /// RazorPages: atributo PrimaryKey.
        /// </summary>
        [Key]
        public int Id { get; set; }  

        /// <summary>
        /// Solicitud de un técnico.
        /// </summary>
        /// <param name="ModoDeContrato"></param>
        /// <param name="RolRequerido"></param>
        /// <param name="HorasContratadas"></param>
        /// <param name="NivelExperiencia"></param>
        /// <param name="Observaciones"></param>
        public Solicitud(int ModoDeContrato, string RolRequerido, int HorasContratadas, string NivelExperiencia, string Observaciones) 
        {
            this.modoDeContrato = ModoDeContrato;
            this.rolRequerido = RolRequerido;
            this.horasContratadas = HorasContratadas;
            this.nivelExperiencia = NivelExperiencia;
            this.observaciones = Observaciones;

            this.status = true;
            
            /// El cliente conoce la cantidad de horas que durante el alta de la solicitud.
            /// Cuando ingresa las horas automáticamente se calcula el costo al precio actual.
            /// Si cambian los precios, el costo se actualiza automáticamente siempre que se encuentra activa.
            ICosto Costo = new Costo();

            this.costoSolicitud = Costo.CalcularCostoSolicitud(ModoDeContrato, HorasContratadas, NivelExperiencia);
            this.ProyectoId = 0;
            this.TecnicoId = 0;
        }

        /// <summary>
        /// Modo de Contratación: (1) por horas y (2) por jornada.
        /// </summary>
        private int modoDeContrato;
        public int ModoDeContrato 
        {
            get => this.modoDeContrato;
            set => this.modoDeContrato = value;
        }

        /// <summary>
        /// Es el rol que se está necesitando.
        /// </summary>
        private string rolRequerido;
        public string RolRequerido 
        {
            get => this.rolRequerido;
            set => this.rolRequerido = value;
        }

        /// <summary>
        /// Registro de las horas contratadas por cliente.
        /// </summary>
        private int horasContratadas;
        public int HorasContratadas 
        {
            get => this.horasContratadas;
            set => this.horasContratadas = value;
        }

        /// <summary>
        /// Es el nivel de experiencia que se necesita (Básico, Avanzado).
        /// </summary>
        private string nivelExperiencia;
        public string NivelExperiencia 
        {
            get => this.nivelExperiencia;
            set => this.nivelExperiencia = value;
        }

        /// <summary>
        /// Observaciones de la solicitud (opcional).
        /// </summary>
        private string observaciones;
        public string Observaciones  
        {
            get => this.observaciones;
            set => this.observaciones = value;
        }

        /// <summary>
        /// Status de la solicitud.
        /// </summary>
        private bool status;
        public bool Status 
        {
            get => this.status;
            protected set {}
        }

        /// <summary>
        /// Costo de la solicitud.
        /// </summary>
        private int costoSolicitud;
        public int CostoSolicitud 
        {
            get => this.costoSolicitud;
            protected set {}
        }

        /// <summary>
        /// Relación Proyecto:Solicitudes (uno-a-muchos)
        /// </summary>
        public int ProyectoId { get; set; }

        /// <summary>
        /// Relación Tecnico:Solicitud (uno-a-uno)
        /// </summary>
        public int TecnicoId { get; set; }

        /// <summary>
        /// Método para asignar un técnico a esta solicitud.
        /// </summary>
        public void AsignarTecnico(int TecnicoId) 
        {
            Check.Precondicion(!string.IsNullOrEmpty(TecnicoId.ToString()), "El técnico no puede ser null o vacío.");

            this.TecnicoId = TecnicoId;
        }

        /// <summary>
        /// Método para agregar horas de contratación.
        /// </summary>
        public void AgregarHoras(int Horas) 
        {
            Check.Precondicion(Math.Abs(Horas) > 0, "El valor debe ser mayor a cero.");

            this.horasContratadas += Math.Abs(Horas);

            // Actualizamos el costo de esta solicitud.
            this.ActualizarCostoSolicitudActiva();
        }

       /// <summary>
        // Método para restar horas de contratación.
       /// </summary>
        public void RestarHoras(int Horas) 
        {
            Check.Precondicion(Math.Abs(Horas) > 0, "El valor debe ser mayor a cero.");
            Check.Precondicion((this.horasContratadas - Math.Abs(Horas)) >= 0, "El resultado no puede ser negativo.");

            if ((this.horasContratadas  - Math.Abs(Horas)) >= 0) this.horasContratadas -= Math.Abs(Horas);

            // Actualizamos el costo de esta solicitud.
            this.ActualizarCostoSolicitudActiva();
        }

        /// <summary>
        /// Este método actualiza el costo para la solicitud.
        /// 
        /// La solicitud debe estar activa para que se realice la modificación.
        /// Se ejecuta en dos oportunidades: 
        /// - cuando se agregan o restan horas
        /// - cuando se actualizan los precios.
        /// </summary>
        public void ActualizarCostoSolicitudActiva() 
        {
            ICosto Costo = new Costo(); 

            if (this.status == true) 
            {
                this.costoSolicitud = Costo.CalcularCostoSolicitud(this.ModoDeContrato, this.HorasContratadas, this.NivelExperiencia);
            }
        }

        /// <summary>
        /// Métodos para cambiar el status.
        /// Activar(): si el proyecto está 'Cerrado' se cambia para 'Activo'.
        /// Cerrar(): si el proyecto está 'Activo' se cambia para 'Cerrado'.
        /// </summary>
        public void Activar() 
        {
            if (this.status == false) this.CambiarStatus();
        }

        public void Cerrar() 
        {
            if (this.status == true) this.CambiarStatus();
        }

        private void CambiarStatus() 
        {
            this.status = !this.status;
        }
    }
}
