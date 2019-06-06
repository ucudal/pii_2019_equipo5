namespace RazorPagesIgnis 
{
    /// <summary>
    /// Implementada por la clase Usuarios.
    /// </summary>
    public interface IUsuariosClientes
    {
        void AgregarCliente(Cliente ClienteNuevo);

        void EliminarCliente(Cliente ClienteEliminar);
    }
}
