using System;
using Xunit;
using Ignis;

namespace tests
{
    public class test
    {
        /// <summary>
        /// Verificamos la construcción de un objeto PROYECTO.
        /// </summary>
        [Fact]
        public void construir_un_objeto_proyecto()
        {
            Proyecto pp = new Proyecto("CentroIgnisApp", "Es una aplicación para el Centro Ignis.");

            string actual = string.Format(@"{0} {1} {2}", pp.Nombre, pp.Descripcion, pp.Status);

            string expected = "CentroIgnisApp Es una aplicación para el Centro Ignis. True";

            Assert.Equal(expected, actual);
        }
    }
}