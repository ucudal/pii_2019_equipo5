using System;
using System.Collections.Generic;

namespace Ignis 
{   
    public class Usuarios : IUsuariosAdministradores, IUsuariosClientes, IUsuariosTecnicos 
    {
        /// Implementamos DIP y ISP agregando las interfases IUsuariosAdministradores, IUsuariosClientes, IUsuariosTecnicos.
        /// Con estas abstracciones separamos las dependencias de otras clases con esta clase.
        /// De acuerdo a ISP, encontramos tres responsabilidades diferentes:
        /// - Agregar o Eliminar un administrador.
        /// - Agregar o Eliminar un cliente.
        /// - Agregar o Eliminar un técnico.

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

        public void AgregarCliente(Cliente ClienteNuevo)  
        {
            listaClientes.Add(ClienteNuevo);
        }

        public void EliminarCliente(Cliente ClienteEliminar)  
        {
            listaClientes.Remove(ClienteEliminar);
        }

        // TÉCNICOS
        private List<Tecnico> listaTecnicos;
        public List<Tecnico> ListaDeTecnicos 
        {
            get => this.listaTecnicos;
            protected set {}
        }

        public void AgregarTecnico(Tecnico TecnicoNuevo)  
        {
            this.listaTecnicos.Add(TecnicoNuevo);
        }

        public void EliminarTecnico(Tecnico TecnicoEliminar)  
        {
            this.listaTecnicos.Remove(TecnicoEliminar);
        }

        // ADMINISTRADORES
        private List<Administrador> listaAdministradores;
        public List<Administrador> ListaAdministradores 
        {
            get => this.listaAdministradores;
            protected set {}
        }

        public void AgregarAdministrador(Administrador AdministradorNuevo)  
        {
            this.listaAdministradores.Add(AdministradorNuevo);
        }

        public void EliminarAdministrador(Administrador AdministradorEliminar)  
        {
            this.listaAdministradores.Remove(AdministradorEliminar);
        }

    }
}