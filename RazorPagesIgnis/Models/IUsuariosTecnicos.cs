namespace RazorPagesIgnis 
{
    public interface IUsuariosTecnicos
    {
        void AgregarTecnico(Tecnico TecnicoNuevo);

        void EliminarTecnico(Tecnico TecnicoEliminar);
    }
}