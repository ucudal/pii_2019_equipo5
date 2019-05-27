using System;

namespace Ignis 
{
    public class Solicitud 
    {
        public Solicitud(string Solicitud_Rol, string Solicitud_Experiencia, string Solicitud_Obs, Tecnico TecnicoAsignado, int HorasRealizadas) 
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