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
        public void construir_un_objeto_persona()
        {
            // preparación
            Persona p1 = new Persona("Leonardo", "leo@correo.ucu.edu.uy", "ZXCV1234");

            string actual = string.Format(@"{0} {1} {2} {3}", p1.Nombre, p1.Correo, p1.Contrasena, p1.Status);

            // esperado
            string expected = "Leonardo leo@correo.ucu.edu.uy ZXCV1234 True";

            // test
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verificamos que el nombre ingresado no sea nulo o vacío.
        /// </summary>
        [Fact]
        public void el_nombre_no_puede_ser_nulo_o_vacio()
        {
            // preparación
            // campo nombre: "X" pasa el test. "" no pasa.
            Persona p1 = new Persona("X", "leo@correo.ucu.edu.uy", "ZXCV1234");   

            // test
            Assert.NotEmpty(p1.Nombre);
            Assert.NotNull(p1.Nombre);            
        }

    }
}
