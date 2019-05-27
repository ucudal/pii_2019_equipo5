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
            Solicitud sol1 = new Solicitud("Electricista", "Básico", "Debe saber conectar luces.", null, 0);
            Solicitud sol2 = new Solicitud("Camarógrafo", "Avanzado", "Con experiencia previa con superhéroes.", null, 0);
            Solicitud sol3 = new Solicitud("Vestuarista", "Avanzado", "Se utilizarán materiales de otro planeta.", null, 0);

            // asociamos técnico a solicitud.
            sol1.AsignarTecnico(t1);
            sol2.AsignarTecnico(t2);
            sol3.AsignarTecnico(tt);

            // agregamos horas.
            sol1.AgregarHoras(8);
            sol2.AgregarHoras(6);
            sol3.AgregarHoras(2);

            // agregamos más horas.
            sol1.AgregarHoras(2);
            sol2.AgregarHoras(5);
            sol3.AgregarHoras(7);

            // restamos horas.
            sol1.RestarHoras(1);
            sol2.RestarHoras(1);
            sol3.RestarHoras(1);

            // Imprimir información.
            Console.WriteLine("Rol: {0} Experiencia: {1} Técnico: {2} Horas realizadas: {3} ", 
                                sol1.Solicitud_Rol, sol1.Solicitud_Experiencia, sol1.TecnicoAsignado.Nombre, sol1.HorasRealizadas);

            Console.WriteLine("Rol: {0} Experiencia: {1} Técnico: {2} Horas realizadas: {3} ", 
                                sol2.Solicitud_Rol, sol2.Solicitud_Experiencia, sol2.TecnicoAsignado.Nombre, sol2.HorasRealizadas);

            Console.WriteLine("Rol: {0} Experiencia: {1} Técnico: {2} Horas realizadas: {3} ", 
                                sol3.Solicitud_Rol, sol3.Solicitud_Experiencia, sol3.TecnicoAsignado.Nombre, sol3.HorasRealizadas);

        }
    }
}
