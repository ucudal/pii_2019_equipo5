namespace Ignis 
{
    public interface IUsuariosAdministradores
    {
        void AgregarAdministrador(Administrador AdministradorNuevo);
        void EliminarAdministrador(Administrador AdministradorEliminar);
    }
}