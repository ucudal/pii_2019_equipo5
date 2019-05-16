using System;
using Xunit;
using Ignis;

namespace tests
{
    public class testsPersona
    {
        [Fact]
        public void se_puede_construir_una_persona()
        {
            // Preparación.
            Persona p1 = new Persona("Leonardo", "leo@correo.ucu.edu.uy", "ZXCV1234");

            string actual = string.Format(@"{0} {1} {2}", p1.Nombre, p1.Correo, p1.Contrasena);

            // Expected
            string esperado = "Leonardo leo@correo.ucu.edu.uy ZXCV1234";

            // Test.
            Assert.Equal(esperado, actual);
        }
    }
}
