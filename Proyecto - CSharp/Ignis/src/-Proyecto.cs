using System;
using System.Collections.Generic;

namespace Ignis 
{   
    public class Proyecto
    {
        public Proyecto(string Nombre, string Descripcion) 
        {
            this.nombre = Nombre;
            this.descripcion = Descripcion;
            this.status = true;

            List<Solicitud> ListaDeSolicitudes = new List<Solicitud>();
            this.listaSolicitudes = ListaDeSolicitudes;
        }
    
        private string nombre;
        public string Nombre  
        { 
            get => this.nombre; 
            protected set {}
        }

        private string descripcion;
        public string Descripcion  
        { 
            get => this.descripcion; 
            set => this.descripcion = value;
        }

        private bool status;
        public bool Status 
        {
            get => this.status;
            protected set {}
        }

        private List<Solicitud> listaSolicitudes;
        public List<Solicitud> ListaDeSolicitudes 
        {
            get => this.listaSolicitudes;
            protected set {}
        }

        public void AsociarSolicitud_a_Proyecto(Solicitud nuevaSolicitud) 
        {
            ListaDeSolicitudes.Add(nuevaSolicitud);
        }

        public void ImprimirInfoProyecto(Costo ListaCosto) 
        {
            Console.WriteLine
                        ("Proyecto: {0} {1} {2}", 
                        this.Nombre, 
                        this.descripcion, 
                        this.status);

            int CostoTotalProyecto = 0;

            for (int i = 0; i < listaSolicitudes.Count; i++) 
            {
                Console.WriteLine
                        ("Solicitud: {0} {1} {2} {3} {4} {5}",
                        this.listaSolicitudes[i].Solicitud_Rol, 
                        this.listaSolicitudes[i].Solicitud_Experiencia, 
                        this.listaSolicitudes[i].Solicitud_Obs, 
                        this.listaSolicitudes[i].TecnicoAsignado.Nombre, 
                        this.listaSolicitudes[i].HorasRealizadas, 
                        CalcularCostoSolicitud(listaSolicitudes[i], ListaCosto)
                        );

                CostoTotalProyecto = CostoTotalProyecto + CalcularCostoSolicitud(listaSolicitudes[i], ListaCosto);
            }

            Console.WriteLine
                        ("El costo total del proyecto {0} es: $ {1}", 
                        this.Nombre, 
                        CostoTotalProyecto);
        }

        // OJO QUE ESTE MÉTODO NO ESTÁ BIEN IMPLEMENTADO. SOLO PARA EJEMPLO.
        public int CalcularCostoSolicitud(Solicitud solicitudIngresada, Costo ListaCosto) 
        {
            int CostoTotalSolicitud = 0;

            CostoTotalSolicitud = solicitudIngresada.HorasRealizadas * ListaCosto.CostoHoraBasico;

            return CostoTotalSolicitud;
        }
    }

}
