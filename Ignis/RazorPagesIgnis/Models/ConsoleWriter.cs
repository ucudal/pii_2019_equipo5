using System;

namespace RazorPagesIgnis 
{   
    public class ConsoleWriter : IConsoleWriter
    {
        /// Constructor sin argumentos y PrimaryKey ID para RazorPages.
        public ConsoleWriter () 
        {
        }

        public int ID { get; set; }

        /// <summary>
        /// Este método recibe un objeto Proyecto e imprime en pantalla su nombre, descrip. y el costo total 
        /// a partir del valor cálculado por la clase Costo.
        /// </summary>
        /// <param name="proy">Objeto Proyecto</param>
        public void imprimirCostoTotalProyecto(Proyecto proy) 
        {
            ICosto ct = new Costo();

            Console.WriteLine ("Proyecto: {0} Estado: {1}", proy.Nombre, formatoProyectoStatus(proy));
            Console.WriteLine ("Descripción del proyecto: {0}", proy.Descripcion);
            Console.WriteLine ("El costo total del proyecto es: $ {1}", ct.CostoTotalProyecto(proy));
        }

        /// <summary>
        /// Este método recibe un objeto Proyecto y retorna una cadena dependiendo del valor de Status (originalmente bool).
        /// Status = true, retorna "Activo".
        /// Status = false, retorna "Cerrado".
        /// </summary>
        /// <param name="proy">Objeto Proyecto</param>
        /// <returns></returns>
        private string formatoProyectoStatus(Proyecto proy)
        {
            if (proy.Status == true) 
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





