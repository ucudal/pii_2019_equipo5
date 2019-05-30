using System;

namespace Ignis
{   
    public class Cliente : Persona 
    {
        public Cliente(string Nombre, string Correo, string Contrasena) 
                    : base(Nombre, Correo, Contrasena) 
        { 
            // Nombre, correo y contraseña: se chequea precondiciones en la clase Persona.
        }

    }
}
