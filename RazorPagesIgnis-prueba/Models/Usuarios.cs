using System;
using System.Collections.Generic;

namespace Ignis 
{   
    public class Usuarios 
    {
        /// <summary>
        /// Esta clase conoce la lista de usuarios y su comportamiento comprende 
        /// las acciones de agregar y eliminar usuarios de las correspondientes listas.
        /// </summary>
        public Usuarios()  
        {   
            List<Cliente> ListaDeClientes = new List<Cliente> {};
            this.listaClientes = ListaDeClientes;

            List<Tecnico> ListaDeTecnicos = new List<Tecnico> {};
            this.listaTecnicos = ListaDeTecnicos;

            List<Administrador> ListaDeAdministradores = new List<Administrador> {};
            this.listaAdministradores = ListaDeAdministradores;
        } 

        // CLIENTES
        private List<Cliente> listaClientes;
        public List<Cliente> ListaDeClientes 
        {
            get => this.listaClientes;
            protected set {}
        }

        public void AgregarCliente(Cliente Cliente_Nuevo)  
        {
            listaClientes.Add(Cliente_Nuevo);
        }

        public void EliminarCliente(Cliente Cliente_a_Eliminar)  
        {
            listaClientes.Remove(Cliente_a_Eliminar);
        }

        // TÉCNICOS
        private List<Tecnico> listaTecnicos;
        public List<Tecnico> ListaDeTecnicos 
        {
            get => this.listaTecnicos;
            protected set {}
        }

        public void AgregarTecnico(Tecnico Tecnico_Nuevo)  
        {
            this.listaTecnicos.Add(Tecnico_Nuevo);
        }

        public void EliminarTecnico(Tecnico Tecnico_a_Eliminar)  
        {
            this.listaTecnicos.Remove(Tecnico_a_Eliminar);
        }

        // ADMINISTRADORES
        private List<Administrador> listaAdministradores;
        public List<Administrador> ListaAdministradores 
        {
            get => this.listaAdministradores;
            protected set {}
        }

        public void AgregarAdministrador(Administrador Administrador_Nuevo)  
        {
            this.listaAdministradores.Add(Administrador_Nuevo);
        }

        public void EliminarAdministrador(Administrador Administrador_a_Eliminar)  
        {
            this.listaAdministradores.Remove(Administrador_a_Eliminar);
        }

    }
}