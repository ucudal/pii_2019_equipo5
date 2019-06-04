namespace Ignis 
{
    public interface IUsuariosClientes
    {
        void AgregarCliente(Cliente ClienteNuevo);

        void EliminarCliente(Cliente ClienteEliminar);
    }
}