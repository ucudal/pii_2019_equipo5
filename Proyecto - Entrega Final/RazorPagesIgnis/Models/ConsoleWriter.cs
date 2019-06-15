using System;

namespace RazorPagesIgnis
{   
    public class ConsoleWriter : IConsoleWriter
    {
        public void ImprimirMensajeConsola(string mensaje) 
        {
            Console.WriteLine(mensaje);
        }

    }
}
