namespace RazorPagesIgnis 
{
    /// <summary>
    /// Implementada por la clase Usuarios.
    /// </summary>
    public interface IUsuariosAdministradores
    {
        void AgregarAdministrador(Administrador AdministradorNuevo);
        void EliminarAdministrador(Administrador AdministradorEliminar);
    }
}