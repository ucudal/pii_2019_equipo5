using System;
using System.Collections;

namespace Ignis 
{   
    public class ListaTecnicos 
    {
        /// <summary>
        /// Esta clase conoce la lista de técnicos y su comportamiento comprende 
        /// las acciones de agregar y eliminar técnicos de la lista.
        /// </summary>
        public ListaTecnicos(ArrayList ListaDeTecnicos) 
        {
            this.listaDeTecnicos = ListaDeTecnicos;
        }

        private ArrayList listaDeTecnicos;
        public ArrayList ListaDeTecnicos { get; set; }

    }
}