using System;

namespace Ignis 
{   
    /// <summary>
    /// Esta clase ons permite chequear Precondiciones, Postcondiciones e Invariantes durante 
    /// la ejecución de la aplicación.
    /// </summary>
    public class Check 
    { 
        /// <summary>
        /// Precondiciones.
        /// </summary>
        public class PrecondicionExcepcion : Exception 
        {
            public PrecondicionExcepcion(string mensaje) : base (mensaje) {} 
        }

         public static void Precondicion(bool condicion, string mensaje) 
         { 
            if (!condicion) 
            { 
                throw new PrecondicionExcepcion(mensaje);
            }
         }

        /// <summary>
        /// Postcondiciones.
        /// </summary>
        public class PostcondicionExcepcion : Exception 
        {
            public PostcondicionExcepcion(string mensaje) : base (mensaje) {} 
        }

         public static void Postcondicion(bool condicion, string mensaje) 
         { 
            if (!condicion) 
            { 
                throw new PostcondicionExcepcion(mensaje);
            }
         }

        /// <summary>
        /// Invariantes.
        /// </summary>
        public class InvarianteExcepcion : Exception 
        {
            public InvarianteExcepcion(string mensaje) : base (mensaje) {} 
        }

         public static void Invariante(bool condicion, string mensaje) 
         { 
            if (!condicion) 
            { 
                throw new InvarianteExcepcion(mensaje);
            }
         }

    }
}
