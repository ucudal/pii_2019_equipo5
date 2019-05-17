using System;
using Xunit;
using Ignis;

namespace tests
{
    public class testsPersona
    {
        /// <summary>
        /// Verificamos la construcción de una persona.
        /// </summary>
        [Fact]
        public void construir_una_persona()
        {
            // preparación
            Persona p1 = new Persona("Leonardo", "leo@correo.ucu.edu.uy", "ZXCV1234");
            string actual = string.Format(@"{0} {1} {2} {3}", p1.Nombre, p1.Correo, p1.Contrasena, p1.Estado);
            // esperado
            string expected = "Leonardo leo@correo.ucu.edu.uy ZXCV1234 True";
            // test
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// El nombre ingresado no puede ser nulo o vacío.
        /// No pasa hasta que no se agrega un nombre.
        /// </summary>
        [Fact]
        public void nombre_no_puede_ser_nulo_o_vacio()
        {
            // preparación
            Persona p1 = new Persona("", "leo@correo.ucu.edu.uy", "ZXCV1234");
            // test
            Assert.NotEmpty(p1.Nombre);
            Assert.NotNull(p1.Nombre);            
        }

        // - Construir una persona correctamente.

        // - El nombre no puede ser nulo o vacío.

        // - El correo debe tener formato adecuado.

        // - La contraseña no puede ser vacía o menor a 4 dígitos.

    }
}
