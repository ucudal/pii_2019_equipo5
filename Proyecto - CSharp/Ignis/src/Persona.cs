using System;

namespace Ignis 
{   
    public class Persona 
    {
        /// <summary>
        /// La clase Persona es superclase de las clases: Cliente, Técnico y Administrador.
        /// Aplicamos polimorfismo, implementando herencia, porque todas estas clases 
        /// utilizan todos sus atributos y comportamientos de esta clase.
        /// </summary>
        public Persona(string Nombre, string Correo, string Contrasena) 
        {
            Check.Precondicion(!string.IsNullOrEmpty(Nombre), "Nombre no puede ser nulo o vacío.");
            Check.Precondicion(validaEmail.EsUnEmailValido(Correo), "Formato de correo incorrecto.");
            Check.Precondicion(validaContrasena.EsUnaContrasenaValida(Contrasena), "La contraseña no cumple los requerimientos necesarios.");

            this.nombre = Nombre;
            this.correo = Correo;
            this.contrasena = Contrasena;
            this.status = statusIni.Valor;

            Check.Postcondicion(this.status == true, "Status no fue actualizado.");
        }

        /// <summary>
        /// La clase ValidarEmail realiza una validación de la dirección de correo electrónico ingresada.
        /// </summary>
        /// <returns>True = Contraseña válida; False = contraseña inválida</returns>
        ValidarEmail validaEmail = new ValidarEmail();

        /// <summary>
        /// La clase ValidarContrasena realiza una validación de la contraseña ingresada.
        /// </summary>
        /// <returns>True = Contraseña válida; False = contraseña inválida</returns>
        ValidarContrasena validaContrasena = new ValidarContrasena();

        /// <summary>
        /// Nombre del usuario.
        /// 
        /// No se permite un valor nulo o vacío.
        /// </summary>
        private string nombre { get; set; } 
        public string Nombre 
        {
            get 
            { 
                return this.nombre; 
            }
            set 
            { 
                Check.Precondicion(!string.IsNullOrEmpty(Nombre), "Nombre no puede ser nulo o vacío.");

                if (!string.IsNullOrEmpty(value)) this.nombre = value;

                Check.Postcondicion(this.nombre == value, "Nombre no fue actualizado.");
            }
        }

        /// <summary>
        /// Dirección de correo electrónico.
        /// 
        /// La información ingresada debe tener formato de dirección de correo electrónico.
        /// </summary>
        private string correo { get; set; }
        public string Correo 
        {
            get 
            { 
                return this.correo; 
            }
            set 
            { 
                Check.Precondicion(validaEmail.EsUnEmailValido(Correo), "Formato de correo incorrecto.");

                if (validaEmail.EsUnEmailValido(value)) this.correo = value;

                Check.Postcondicion(this.correo == value, "Dirección de correo no fue actualizado.");
            }
        }

        /// <summary>
        /// Contraseña del usuario.
        /// 
        /// Debe cumplir con las condiciones detalladas en la clase EsUnaContrasenaValida (archivo ValidarContrasena.cs)
        /// </summary>
        private string contrasena { get; set; }
        public string Contrasena  
        {
            get 
            { 
                return this.contrasena;
            }
            set 
            { 
                Check.Precondicion(validaContrasena.EsUnaContrasenaValida(Contrasena), "La contraseña no cumple los requerimientos necesarios.");
                
                if (validaContrasena.EsUnaContrasenaValida(value)) this.contrasena = value;

                Check.Postcondicion(this.contrasena == value, "Contraseña no fue actualizada.");
            }
        }

        /// <summary>
        /// La clase Status permite gestionar el estado operativo del usuario.
        /// </summary>
        /// <returns>True = usuario activo; False = usuario inactivo</returns>
        private Status statusIni = new Status(true);

        private bool status { get; set; }
        public bool Status 
        {
            get => this.status; 
            protected set {}
        }

    }
}
