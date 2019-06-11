using System;
using System.Collections.Generic;

namespace RazorPagesIgnis 
{   
    public class ConsoleWriter //: //IConsoleWriter
    {
        /// <summary>
        /// Para RazorPages: constructor sin argumentos, atributo ID es PrimaryKey para la base.
        /// </summary>
        public ConsoleWriter () 
        {
        }

        public int ID { get; set; }

        /// <summary>
        /// Este método recibe un mensaje con un objeto Proyecto como parámetro.
        /// Imprime en pantalla su nombre, descrip. y el costo total 
        /// a partir del valor cálculado por la clase Costo.
        /// </summary>
        /// <param name="Proyecto">Objeto Proyecto</param>
        public void ImprimirCostoTotalDelProyecto(Proyecto proyecto) 
        {
            ICosto Costo = new Costo();

            Console.WriteLine ("Proyecto: {0} Estado: {1}", proyecto.Nombre, ValorDeStatusDelProyecto(proyecto));

            Console.WriteLine ("Descripción del proyecto: {0}", proyecto.Descripcion);

            private int CostoTotal = 0;

            foreach (var item in proyecto.ListaDeSolicitudes)
            {
                CostoTotal += Costo.CalcularCostoSolicitud(item.ModoDeContrato, item.HorasContratadas, item.NivelExperiencia);
            }
            foreach (Solicitud item in this.ListaDeSolicitudes)
            {
                item.Cerrar();
            }

        }
        

        //     foreach (var solicitud in proyecto.ListaDeSolicitudes) 
        //         {
        //             CostoTotal += Proyecto.   0;
        //         }

        //     //Console.WriteLine ("El costo total del proyecto es: $ {1}", 
            

        // }

        /// <summary>
        /// Este método recibe un objeto Proyecto y retorna una cadena dependiendo del valor de Status (originalmente bool).
        /// Status = true, retorna "Activo".
        /// Status = false, retorna "Cerrado".
        /// </summary>
        /// <param name="Proyecto">Objeto Proyecto</param>
        private string ValorDeStatusDelProyecto(Proyecto Proyecto)
        {
            if (Proyecto.Status == true) 
            {
                return "Activo";
            }
            else 
            {
                return "Cerrado";
            }
        }

    }
}





