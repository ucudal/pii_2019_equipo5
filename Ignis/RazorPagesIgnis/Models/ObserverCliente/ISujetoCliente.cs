using System;
using System.Collections.Generic;

namespace RazorPagesIgnis 
{
    public abstract class ISujetoCliente 
    {
        private List<IObserverCliente> ListaDeObservers = new List<IObserverCliente>();
        
        public void Agregar(IObserverCliente observer) 
        {
            ListaDeObservers.Add(observer);
        }

        public void Eliminar(IObserverCliente observer) 
        { 
            ListaDeObservers.Remove(observer);
        }

        public void Notificar() 
        {
            foreach (IObserverCliente observer in ListaDeObservers)
            {
                observer.Inhabilitar();
            }
        }
    }

}
