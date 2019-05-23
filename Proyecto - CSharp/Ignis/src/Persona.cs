using System;

namespace Ignis 
{   
    public class Persona 
    {
        /// <summary>
        /// La clase Persona es superclase de las clases: Cliente, Técnico y Administrador.
        /// Considerando la propiedad polimórfica, implementamos herencia porque todas 
        /// estas clases utilizan todos sus atributos y comportamientos.
        /// 
        /// A los efectos de encapsulamiento, implementamos getters y setters 
        /// de acuerdo con cada atributo, que en algunos casos nos permitió validar el ingreso de valores.
        /// </summary>
        public Persona(string Nombre, string Correo, string Contrasena) 
        {
            this.nombre = Nombre;
            this.correo = Correo;
            this.contrasena = Contrasena;
            this.status = statusInicial.Valor;
        }


        /// <summary>
        /// Esta instancia de Status es para que durante la creación del objeto 
        /// nos permita establecer el status inicial del usuario como activo (true).
        /// </summary>
        private Status statusInicial = new Status(true);


        /// <summary>
        /// Atributo: Nombre del usuario.
        /// Validación: SET, no permite datos nulos o vacíos.
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
                if (string.IsNullOrEmpty(value)) 
                    throw new ArgumentException("No se puede ingresar un valor nulo o vacío.");
                
                this.nombre = value;
            }
        }


        /// <summary>
        /// Atributo: Dirección de casilla de correo del usuario.
        /// Validación: SET, el valor ingresado debe tener formato de dirección de correo electrónico.
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
                ValidarEmail ve = new ValidarEmail();

                if ( !ve.EsUnEmailValido(value) )
                    throw new ArgumentException("El formato de correo ingresado no es correcto.");
                
                this.correo = value;
            }
        }


        /// <summary>
        /// Atributo: Contraseña del usuario.
        /// Validación: SET, debe cumplir con las condiciones detallas en la clase EsUnaContrasenaValida (archivo ValidarContrasena.cs) 
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
                ValidarContrasena vc = new ValidarContrasena();
                
                if ( !vc.EsUnaContrasenaValida(value) ) 
                    throw new ArgumentException("El formato o largo de la contraseña no es válida.");

                this.contrasena = value;
            }
        }


        /// <summary>
        /// Atributo: Status.
        /// </summary>
        private bool status { get; set; }
        public bool Status
        {
            get => this.status;
            protected set {}
        }

    }
}
