using System;
using System.Collections;

namespace Ignis 
{   
    public class ListaProyectos 
    {
        /// <summary>
        /// Esta clase conoce la lista de los proyectos y su comportamiento comprende 
        /// las acciones de agregar y eliminar proyectos de la lista.
        /// </summary>
        public ListaProyectos(ArrayList ListaDeProyectos) 
        {
            this.listaDeProyectos = ListaDeProyectos;
        }

        private ArrayList listaDeProyectos;
        public ArrayList ListaDeProyectos { get; set; }
    }
}
