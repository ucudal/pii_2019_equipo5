using System;

namespace Ignis //src
{
    class Program
    {
        static void Main(string[] args)
        {
            // probando la creación de una persona
            Persona pp = new Persona("Marcelo", "marce@ucu.uy", "qwer1234");

            Console.WriteLine("{0} {1} {2} {3}", pp.Nombre, pp.Correo, pp.Contrasena, pp.Status);

            // probando la creación de un técnico.
            Tecnico tt = new Tecnico("Gonzalo", "gonza@ucu.uy", "abc123", 33, "", "", 0,0);
            Console.WriteLine("{0} {1} {2} {3} {4}", tt.Nombre, tt.Correo, tt.Contrasena, tt.Edad, tt.Status);

            // probando validar un email.
            ValidarEmail ve = new ValidarEmail();

            string emaildir1 = "correoCorrecto@dominio.com";

            Console.WriteLine("Validar " + emaildir1 + "nos devuelve: " + ve.EsUnEmailValido(emaildir1));

            string emaildir2 = "correoIncorrecto@dominio";

            Console.WriteLine("Validar " + emaildir2 + "nos devuelve: " + ve.EsUnEmailValido(emaildir2));

            // probando validar una contraseña.
            ValidarContrasena vc = new ValidarContrasena();

            string clave1 = "";
            string clave2 = "a@1";
            string clave3 = "ClaveCorrecta1";

            Console.WriteLine("Validar la contraseña: " + clave1 + "(vacío) nos devuelve: " + vc.EsUnaContrasenaValida(clave1));
            Console.WriteLine("Validar la contraseña: " + clave2 + " nos devuelve: " + vc.EsUnaContrasenaValida(clave2));
            Console.WriteLine("Validar la contraseña: " + clave3 + " nos devuelve: " + vc.EsUnaContrasenaValida(clave3));

            MailTecnico rr = new MailTecnico("hola",tt,pp,"esto es el contenido","Esto es el cuerpo");
            rr.enviar();
        }
    }
}
