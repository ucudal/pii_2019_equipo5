using System;

namespace RazorPagesIgnis 
{   
    public class Costo : ICosto 
    { 
        /// <summary>
        /// Esta clase conoce el costo por hora para cada modo de contratación y catégoria de técnico.
        /// Tiene la responsabilidad de calcular el costo de una solicitud.
        /// </summary>
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

        public int CalcularCostoSolicitud(int ModoDeContrato,int HorasContratadas,string NivelExperiencia) 
        {
            int CostoTotalSolicitud = 0;
            int modulo = 0;

            if (ModoDeContrato == 1 )
            {
                if (NivelExperiencia == "Avanzado" )
                {
                    CostoTotalSolicitud = (HorasContratadas -1) * this.CostoHoraAvanzado;
                    CostoTotalSolicitud = CostoTotalSolicitud + this.primeraHoraAvanzado;
                }
                else
                {
                    CostoTotalSolicitud = (HorasContratadas -1) * this.CostoHoraBasico;
                    CostoTotalSolicitud = CostoTotalSolicitud + this.primeraHoraBasico;                      
                }
            }
            else// si modocontrato es 2 es por jornada
            {
                if (NivelExperiencia == "Basico" )
                {
                    modulo= HorasContratadas / this.horaJornada;
                    int resta = HorasContratadas - (modulo * this.horaJornada);
                    CostoTotalSolicitud = (resta*this.costoHoraBasico) + (modulo * this.jornadaBasico);
                }
                else 
                {
                    modulo= HorasContratadas / this.horaJornada;
                    int resta = HorasContratadas - (modulo * this.horaJornada);
                    CostoTotalSolicitud = (resta*this.costoHoraAvanzado) + (modulo * this.jornadaAvanzado);
                }
            }

            return CostoTotalSolicitud;

        }

    //     //int CostoTotalProyectos = 0;
    //    /*  
    //     public int CostoTotalProyecto(Proyecto proyecto) 
    //     {
    //         for (int i = 0; i < proyecto.ListaDeSolicitudes.Count; i++) 
    //         {
    //             CalcularCostoSolicitud(proyecto.ListaDeSolicitudes[i]);
    //             CostoTotalProyectos = CostoTotalProyectos + CalcularCostoSolicitud(proyecto.ListaDeSolicitudes[i]);
    //         }
    //         return CostoTotalProyectos; 
    //     }

    }
}
