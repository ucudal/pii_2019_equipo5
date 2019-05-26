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
            // this.listaClientes = ListaDeClientes;
            this.listaTecnicos = ListaDeTecnicos;
            // this.listaAdministradores = ListaDeAdministradores;
        } 

        // // CLIENTES
        // private List<Cliente> listaClientes;
        // public List<Cliente> ListaDeClientes 
        // {
        //     get => this.listaClientes;
        //     protected set {}
        // }

        // public void AgregarCliente(Cliente nuevoCliente)  
        // {
        //     listaClientes.Add(nuevoCliente);
        // }

        // public void EliminarCliente(Cliente borrarCliente)  
        // {
        //     listaClientes.Remove(borrarCliente);
        // }

        // TÉCNICOS
        private List<Tecnico> listaTecnicos;
        public List<Tecnico> ListaDeTecnicos 
        {
            get => this.listaTecnicos;
            protected set {}
        }

        public void AgregarTecnico(Tecnico nuevoTecnico)  
        {
            listaTecnicos.Add(nuevoTecnico);
        }

        public void EliminarTecnico(Tecnico borrarTecnico)  
        {
            listaTecnicos.Remove(borrarTecnico);
        }

        // // ADMINISTRADORES
        // private List<Administrador> listaAdministradores;
        // public List<Administrador> ListaDeAdministradores  
        // {
        //     get => this.listaAdministradores;
        //     protected set {}
        // }

        // public void AgregarAdministrador(Administrador nuevoAdministrador)  
        // {
        //     listaAdministradores.Add(nuevoAdministrador);
        // }

        // public void EliminarAdministrador(Administrador borrarAdministrador)  
        // {
        //     listaAdministradores.Remove(borrarAdministrador);
        // }
    }
}