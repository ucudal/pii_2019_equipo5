namespace RazorPagesIgnis 
{
    /// <summary>
    /// Implementada por la clase Informe.
    /// </summary>
    public interface IInforme
    {
        void InformeProyectoCostoTotalResumen(Proyecto Proyecto);

        void InformeProyectoCostoTotalDetallado(Proyecto Proyecto);
    }
}