using System;
using System.Collections.Generic;

namespace RazorPagesIgnis
{
    public abstract class ISujetoProyecto 
    {
        private List<IObserverProyecto> ListaDeObservers = new List<IObserverProyecto>();
        
        public void Agregar(IObserverProyecto observer) 
        {
            ListaDeObservers.Add(observer);
        }

        public void Eliminar(IObserverProyecto observer) 
        { 
            ListaDeObservers.Remove(observer);
        }

        public void Notificar() 
        {
            foreach (IObserverProyecto observer in ListaDeObservers)
            {
                observer.Cerrar();
            }
        }
    }

}
