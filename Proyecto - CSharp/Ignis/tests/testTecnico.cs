using System;
using Xunit;
using Ignis;

namespace tests
{
    public class testsTecnico
    {
        /// <summary>
        /// Verificamos la construcción de un objeto tecnico.
        /// </summary>
        [Fact]
        public void construir_un_objeto_tecnico()
        {
            // preparación
            Tecnico t1 = new Tecnico("Gonzalo", "gonza@correo", "abc123", 33);

            string actual = string.Format(@"{0} {1} {2} {3} {4}", t1.Nombre, t1.Correo, t1.Contrasena, t1.Edad, t1.Status);

            // esperado
            string expected = "Gonzalo gonza@correo abc123 33 True";

            // test
            Assert.Equal(expected, actual);
        }
    }
}
