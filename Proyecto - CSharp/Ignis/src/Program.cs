using System;
using System.Collections.Generic;

namespace Ignis //src
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos persona.
            Persona pp = new Persona("Marcelo", "marce@ucu.uy", "qwer1234");

            Console.WriteLine("Creamos persona:");
            Console.WriteLine("{0} {1} {2} {3}", pp.Nombre, pp.Correo, pp.Contrasena, pp.Status);

            // creamos técnico.
            Tecnico tt = new Tecnico("Gonzalo", "gonza@ucu.uy", "abc123", 33, "mipresentacion", "Básico");

            Console.WriteLine("Creamos técnico:");
            Console.WriteLine("{0} {1} {2} {3}", tt.Nombre, tt.Edad, tt.Presentacion, tt.Nivel_experiencia);

            // creamos lista de técnicos.
            Usuarios uu = new Usuarios();

            uu.AgregarTecnico(tt);

            // creamos cliente.

            // creamos proyecto.

            // creamos solicitud.

            // asociamos técnico a solicitud.

        }
    }
}
