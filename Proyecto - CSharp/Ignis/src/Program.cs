using System;

namespace Ignis //src
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Marcelo", "marce@correo", "qwer1234");

            Console.WriteLine("{0} {1} {2} {3}", p1.Nombre, p1.Correo, p1.Contrasena, p1.Status);

        }
    }
}
