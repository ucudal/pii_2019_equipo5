using System;
using System.Collections;

namespace RazorPagesIgnis 
{   
    public class ListaCostos
    {
        /// <summary>
        /// Esta clase conoce la lista de costos y su comportamiento comprende 
        /// las acciones de agregar y eliminar técnicos de la lista.
        /// </summary>
        public ListaCostos(ArrayList ListaDeCostos) 
        {
            this.listaCostos = ListaDeCostos;
        }

        private ArrayList listaCostos;
        public ArrayList ListaDeCostos { get; set; }

    }
}