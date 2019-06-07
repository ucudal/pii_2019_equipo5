using System;

namespace RazorPagesIgnis 
{   
    public class ConsoleWriter : IConsoleWriter
    {
        public ConsoleWriter () 
        {
        }

        /// Para RazorPages: el atributo ID es PrimaryKey para la base.
        public int ID { get; set; }

        /// <summary>
        /// Este método recibe un mensaje con un objeto Proyecto como parámetro.
        /// Imprime en pantalla su nombre, descrip. y el costo total 
        /// a partir del valor cálculado por la clase Costo.
        /// </summary>
        /// <param name="Proyecto">Objeto Proyecto</param>
        public void ImprimirCostoTotalDelProyecto(Proyecto Proyecto) 
        {
            ICosto Costo = new Costo();

            Console.WriteLine ("Proyecto: {0} Estado: {1}", Proyecto.Nombre, ValorDeStatusDelProyecto(Proyecto));
            Console.WriteLine ("Descripción del proyecto: {0}", Proyecto.Descripcion);
            Console.WriteLine ("El costo total del proyecto es: $ {1}", Costo.CostoTotalProyecto(Proyecto));
        }

        /// <summary>
        /// Este método recibe un objeto Proyecto y retorna una cadena dependiendo del valor de Status (originalmente bool).
        /// Status = true, retorna "Activo".
        /// Status = false, retorna "Cerrado".
        /// </summary>
        /// <param name="Proyecto">Objeto Proyecto</param>
        /// <returns></returns>
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





