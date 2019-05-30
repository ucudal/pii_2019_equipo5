using System;

namespace Ignis 
{   
    public class Costo 
    {
        public Costo() 
        {
            this.costoHoraBasico = 150;
            this.costoHoraAvanzado = 280;
        }

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


        public int CalcularCostoSolicitud(Solicitud solicitudIngresada) 
        {
            int CostoTotalSolicitud = 0;
            int modulo = 0;


            if (solicitudIngresada.Solicitud_Experiencia == "Avanzado"){
               
                if (solicitudIngresada.HorasRealizadas < 6 )
                {
                    
                    CostoTotalSolicitud = (solicitudIngresada.HorasRealizadas -1) * this.CostoHoraAvanzado;
                    CostoTotalSolicitud = CostoTotalSolicitud + 520;
                }
                else {
                    modulo= solicitudIngresada.HorasRealizadas % 6;//horas por jornada
                    int resta = solicitudIngresada.HorasRealizadas - (modulo * 6);
                    CostoTotalSolicitud = (resta*this.costoHoraAvanzado) + (modulo * 2000);//precio jornada
                }
            }

            else
            {
                if (solicitudIngresada.HorasRealizadas < 6 ){
                    
                    CostoTotalSolicitud = (solicitudIngresada.HorasRealizadas -1) * this.CostoHoraBasico;
                    CostoTotalSolicitud = CostoTotalSolicitud + 380;
                }
                else {
                    modulo= solicitudIngresada.HorasRealizadas % 6;
                    int resta = solicitudIngresada.HorasRealizadas - (modulo * 6);
                    CostoTotalSolicitud = (resta*this.costoHoraBasico) + (modulo * 1200);
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
