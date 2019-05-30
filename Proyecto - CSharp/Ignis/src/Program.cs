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

            // creamos administrador.
            Administrador adm = new Administrador("Natalia", "natalia@hotmail.com", "as34fd23");

            // agregamos el administrador a las lista de administradores.
            uu.AgregarAdministrador(adm);

            // creamos cliente.
            Cliente cc = new Cliente("Gustavo", "gus@hotmail.com", "asdf4356");

            // agregamos clientes a las lista de clientes.
            uu.AgregarCliente(cc);
            
            // creamos proyecto.
            Proyecto proy1 = new Proyecto("Hulk Aplasta !!!", "Historia de un super héroe.");
            Proyecto proy2 = new Proyecto("Spiderman 5", "Deberá combatir nuevamente a Octopus.");

            // creamos solicitud.
            Solicitud sol1 = new Solicitud("Electricista", "Básico", "Debe saber conectar luces.", null, 0);
            Solicitud sol2 = new Solicitud("Camarógrafo", "Avanzado", "Con experiencia previa con superhéroes.", null, 0);
            Solicitud sol3 = new Solicitud("Vestuarista", "Avanzado", "Se utilizarán materiales de otro planeta.", null, 0);

            // Asociamos solicitudes al proyecto.
            proy1.AsociarSolicitud_a_Proyecto(sol1);
            proy1.AsociarSolicitud_a_Proyecto(sol2);
            proy2.AsociarSolicitud_a_Proyecto(sol3);

            // asociamos técnico a solicitud.
            sol1.AsignarTecnico(t1);
            sol2.AsignarTecnico(t2);
            sol3.AsignarTecnico(tt);

            // agregamos horas.
            sol1.AgregarHoras(1);
            sol2.AgregarHoras(1);
            sol3.AgregarHoras(13);

            // agregamos más horas.
            sol1.AgregarHoras(1);
            sol2.AgregarHoras(1);
            sol3.AgregarHoras(1);

            // restamos horas.
            sol1.RestarHoras(1);
            sol2.RestarHoras(1);
            sol3.RestarHoras(1);

            // Cargamos costos.
           /* Costo costos = new Costo();

            costos.ModificarCostoHoraBasico(125);
            costos.ModificarCostoHoraAvanzado(250);*/

            // Imprimir información.
            proy1.ImprimirInfoProyecto();
            proy2.ImprimirInfoProyecto();

           
        }
    }
}
