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
            Tecnico t1 = new Tecnico("Marcos", "marcos@correo.com", "ab123", 40, "mepresento", "Avanzado");
            Tecnico t2 = new Tecnico("Marcelo", "marce@correo.ucu.edu.uy", "abc123", 33, "mipresentacion", "Básico");

            Usuarios uu = new Usuarios();

            uu.AgregarTecnico(tt);
            uu.AgregarTecnico(t1);
            uu.AgregarTecnico(t2);

            // creamos cliente.
            Cliente cc = new Cliente("Gustavo", "gus@hotmail.com", "asdf4356");

            // creamos proyecto.
            Proyecto proy = new Proyecto("Película Superman 2", "Historia de un super héroe.");

            // creamos solicitud.
            Solicitud sol1 = new Solicitud("Electricista", "Básico", "Debe saber conectar luces.");
            Solicitud sol2 = new Solicitud("Camarógrafo", "Avanzado", "Con experiencia previa con superhéroes.");
            Solicitud sol3 = new Solicitud("Vestuarista", "Avanzado", "Se utilizarán materiales de otro planeta.");

            // asociamos técnico a solicitud.


        }
    }
}
