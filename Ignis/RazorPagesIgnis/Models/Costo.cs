using System;

namespace RazorPagesIgnis 
{   
    /// <summary>
    /// Esta clase conoce la categoria, precio primera hora, precio de hora y precio por jornada. 
    /// Tiene la responsabilidad de calcular las horas por solicitud de proyecto, y el costo total del proyecto.
    /// </summary>
    public class Costo : ICosto 
    {
        public Costo() 
        {
            this.costoHoraBasico = 150;
            this.costoHoraAvanzado = 280;
            this.primeraHoraBasico = 380;
            this.primeraHoraAvanzado = 520;
            this.jornadaAvanzado=2000;
            this.jornadaBasico=1200;
            this.horaJornada=6;
        }

        public int ID { get; set; }

        //cantidad de horas por jornada
        private int horaJornada;
        public int HoraJornada 
        {
            get => this.horaJornada;
            protected set {}
        }

        public void ModificarHoraJornada(int nuevoCosto) 
        {
            this.horaJornada = nuevoCosto;
        }
        
        //costo basico
        private int costoHoraBasico;
        public int CostoHoraBasico 
        {
            get => this.costoHoraBasico;
            protected set {}
        }

        public void ModificarCostoHoraBasico(int nuevoCosto) 
        {
            this.costoHoraBasico = nuevoCosto;
        }

        //costo avanzado
        private int costoHoraAvanzado;
        public int CostoHoraAvanzado 
        {
            get => this.costoHoraAvanzado;
            protected set {}
        }

        public void ModificarCostoHoraAvanzado(int nuevoCosto) 
        {
            this.costoHoraAvanzado = nuevoCosto;
        }


        //primera hora
        private int primeraHoraBasico;
        public int PrimeraHoraBasico 
        {
            get => this.primeraHoraBasico;
            protected set {}
        }

        public void ModificarPrimeraHoraBasico(int nuevoCosto) 

        {
            this.primeraHoraBasico = nuevoCosto;
        }


        private int primeraHoraAvanzado;
        public int PrimeraHoraAvanzado 
        {
            get => this.primeraHoraAvanzado;
            protected set {}
        }

        public void ModificarPrimeraHoraAvanzado(int nuevoCosto) 
        {
            this.primeraHoraAvanzado = nuevoCosto;
        }
        
        private int jornadaBasico;
        public int JornadaBasico
        {
            get => this.jornadaBasico;
            protected set {}
        }

        public void ModificarJornadaBasico(int nuevoCosto) 
        {
            this.jornadaBasico = nuevoCosto;
        }

        private int jornadaAvanzado;
        public int JornadaAvanzado
        {
            get => this.jornadaAvanzado;
            protected set {}
        }

        public void ModificarJornadaAvanzado(int nuevoCosto) 
        {
            this.jornadaAvanzado = nuevoCosto;
        }

        public int CalcularCostoSolicitud(Solicitud solicitudIngresada) 
        {
            int CostoTotalSolicitud = 0;
            int modulo = 0;


            if (solicitudIngresada.NivelExperiencia == "Avanzado"){
               
                if (solicitudIngresada.HorasRealizadas < this.horaJornada )
                {
                    
                    CostoTotalSolicitud = (solicitudIngresada.HorasRealizadas -1) * this.CostoHoraAvanzado;
                    CostoTotalSolicitud = CostoTotalSolicitud + this.primeraHoraAvanzado;
                }
                else
                 {
                    modulo= solicitudIngresada.HorasRealizadas / this.horaJornada;
                    int resta = solicitudIngresada.HorasRealizadas - (modulo * this.horaJornada);
                    CostoTotalSolicitud = (resta*this.costoHoraAvanzado) + (modulo * this.jornadaAvanzado);
                }
            }

            else
            {
                if (solicitudIngresada.HorasRealizadas < this.horaJornada ){
                    
                    CostoTotalSolicitud = (solicitudIngresada.HorasRealizadas -1) * this.CostoHoraBasico;
                    CostoTotalSolicitud = CostoTotalSolicitud + this.primeraHoraBasico;
                }
                else {
                    modulo= solicitudIngresada.HorasRealizadas / this.horaJornada;
                    int resta = solicitudIngresada.HorasRealizadas - (modulo * this.horaJornada);
                    CostoTotalSolicitud = (resta*this.costoHoraBasico) + (modulo * this.jornadaBasico);
                }
            }
            return CostoTotalSolicitud;
        }

        int CostoTotalProyectos = 0;
         
        public int CostoTotalProyecto(Proyecto proyecto) 
        {
            for (int i = 0; i < proyecto.ListaDeSolicitudes.Count; i++) 
            {
                CalcularCostoSolicitud(proyecto.ListaDeSolicitudes[i]);
                CostoTotalProyectos = CostoTotalProyectos + CalcularCostoSolicitud(proyecto.ListaDeSolicitudes[i]);
            }
            return CostoTotalProyectos; 
        }

    }
}
