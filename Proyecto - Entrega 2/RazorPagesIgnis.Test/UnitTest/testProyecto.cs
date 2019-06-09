using System;
using System.Collections.Generic;
using Xunit;
using RazorPagesIgnis;

namespace tests
{
    public class testsProyecto
    {
        /// <summary>
        /// Verificamos la construcción de un objeto tecnico.
        /// </summary>
        [Fact]
        public void construir_un_proyecto()
        {
            Proyecto proyecto1 = new Proyecto("Proyecto1", "descripcion");

            string actual = string.Format(@"{0} {1}", proyecto1.Nombre, proyecto1.Descripcion);
 
            string expected = "Proyecto1 descripcion";

            Assert.Equal(expected, actual);
        }

    }
}
