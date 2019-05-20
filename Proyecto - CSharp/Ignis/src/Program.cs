using System;

namespace Ignis //src
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Marcelo", "marce@correo", "qwer1234");

            Console.WriteLine("{0} {1} {2} {3}", p1.Nombre, p1.Correo, p1.Contrasena, p1.Status);

            Tecnico t1 = new Tecnico("Gonzalo", "gonza@correo", "abc123", 33);

            Console.WriteLine("{0} {1} {2} {3} {4}", t1.Nombre, t1.Correo, t1.Contrasena, t1.Edad, t1.Status);

        }
    }
}
