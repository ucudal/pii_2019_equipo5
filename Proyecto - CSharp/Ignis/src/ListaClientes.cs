using System;
using System.Collections;

namespace Ignis 
{   
    public class ListaClientes 
    {
        /// <summary>
        /// Esta clase conoce la lista de técnicos y su comportamiento comprende 
        /// las acciones de agregar y eliminar técnicos de la lista.
        /// </summary>
        public ListaClientes(ArrayList ListaDeClientes) 
        {
            this.listaDeClientes = ListaDeClientes;
        }

        private ArrayList listaDeClientes;
        public ArrayList ListaDeClientes { get; set; }

    }
}