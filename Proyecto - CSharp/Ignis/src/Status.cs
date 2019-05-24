using System;

namespace Ignis
{   
    public class Status
    {
        /// <summary>
        /// El Status de un usuario permite al Administrador de Ignis habilitar/deshabilitar 
        /// las operaciones en la aplicación. Por ejemplo, un técnico con Status = Inactivo 
        /// puede ingresar y consultar históricos pero no puede ser asignado a proyectos.
        /// 
        /// Durante la creación del objeto Cliente, Tecnico o Administrador, debido a la herencia 
        /// de estos de la clase Persona, el atributo Status se implementa como un objeto 
        /// que tiene un valor 'Activo' y los comportamientos de 'Activar' y 'Desactivar'.
        /// 
        /// Status del usuario: Activo (True), Inactivo (False).
        /// </summary>
        public Status(bool Valor)  
        {
            this.valor = Valor;
        }

        private bool valor { get; set; }
        public bool Valor 
        { 
            get 
            {
                return this.valor;
            }
            protected set {}
        }

        /// <summary>
        /// Métodos para cambiar el status, 
        /// Activar(): si el usuario está 'Inactivo' se cambia para 'Activo'.
        /// Inactivar(): si el usuario está "Activo" se cambia para "Inactivo".
        /// </summary>
        public void Activar() 
        {
            if (this.valor == false) { this.CambiarStatus(); }
        }

        public void Inactivar() 
        {
            if (this.valor == true) { this.CambiarStatus(); }
        }

        /// <summary>
        /// Método para alternar el calor del atributo Status.
        /// </summary>
        private void CambiarStatus() 
        {
            this.valor = !this.valor;
        }

    }
}
