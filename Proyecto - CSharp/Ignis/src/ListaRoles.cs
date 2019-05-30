using System;
using System.Collections;

namespace Ignis 
{   
    public class ListaRoles
    {
        public ListaRoles(ArrayList ListaRoles) 
        {
            this.ListaRoles = ListaRoles;
        }

        private ArrayList listaRoles;
        public ArrayList ListaRoles { get; set; }

    }
}