using System;

namespace RazorPagesIgnis
{
    public class Informe :IInforme
    {
        public void InformeProyectoCostoTotalDetallado(Proyecto Proyecto) 
        {
            // IConsoleWriter consola = new ConsoleWriter();

            // int CostoTotal = 0;
            
            // string LineaSolicitud = "";

            // consola.ImprimirMensajeConsola("Proyecto: " + Proyecto.Nombre);

            // foreach (Solicitud s in Proyecto.ListaDeSolicitudes) 
            // {
            //     LineaSolicitud = string.Format("Modo: {0}    Rol Requerido: {1}    Horas Contratadas: {2}    Nivel: {3}    Costo: {4}", 
            //         s.ModoDeContrato, 
            //         s.RolRequerido, 
            //         s.HorasContratadas, 
            //         s.NivelExperiencia, 
            //         s.CostoSolicitud);

            //     consola.ImprimirMensajeConsola(LineaSolicitud);

            //     CostoTotal += s.CostoSolicitud;
            // }

            // consola.ImprimirMensajeConsola(string.Format("Costo Total del Proyecto: $ " + CostoTotal));
        }

        public void InformeProyectoCostoTotalResumen(Proyecto Proyecto) 
        {
            // IConsoleWriter consola = new ConsoleWriter();

            // int CostoTotal = 0;
            
            // consola.ImprimirMensajeConsola("Proyecto: " + Proyecto.Nombre);

            // foreach (Solicitud s in Proyecto.ListaDeSolicitudes) 
            // {
            //     CostoTotal += s.CostoSolicitud;
            // }

            // consola.ImprimirMensajeConsola(string.Format("Costo Total del Proyecto: $ " + CostoTotal));
        }
    }
}
