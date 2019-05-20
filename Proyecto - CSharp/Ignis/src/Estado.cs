using System;

namespace Ignis
{   
    public class Status
    {
        /// <summary>
        /// El STATUS de un objeto permite al Administrador de Ignis habilitar/deshabilitar 
        /// las operaciones de ese objeto. Por ejemplo, un técnico con Status = Inactivo 
        /// puede consultar históricos pero no puede ser asignado a proyectos.
        /// 
        /// Status: Activo (True), Inactivo (False).
        /// </summary>
        public Status(bool Valor)  
        {
            this.valor = Valor;
        }

        private bool valor { get; set; }

        public bool Valor 
        { 
            get { return this.valor; }
            private set {}
        }


        /// <summary>
        /// Método para cambiar el atributo Status.
        /// </summary>
        private void CambiarStatus() 
        {
            this.valor = !this.valor;
        }


        /// <summary>
        /// Método para activar un objeto.
        /// </summary>
        public void Activar() 
        {
            if (this.valor == false) { this.CambiarStatus(); }
        }


        /// <summary>
        /// Método para inactivar un objeto.
        /// </summary>
        public void Inctivar() 
        {
            if (this.valor == true) { this.CambiarStatus(); }
        }

    }
}
