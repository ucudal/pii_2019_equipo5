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
            Persona p1 = new Persona("Leonardo", "leo@correo.ucu.edu.uy", "ZXCV1234");

            string actual = string.Format(@"{0} {1} {2} {3}", p1.Nombre, p1.Correo, p1.Contrasena, p1.Status);

            string expected = "Leonardo leo@correo.ucu.edu.uy ZXCV1234 True";

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verificamos que el nombre ingresado no sea nulo o vacío.
        /// </summary>
        [Fact]
        public void el_nombre_no_puede_ser_nulo_o_vacio()
        {
            // campo nombre: "X" pasa el test, si lo borramos "" no pasa.
            Persona p1 = new Persona("X", "leo@correo.ucu.edu.uy", "ZXCV1234");   

            Assert.NotEmpty(p1.Nombre);
            Assert.NotNull(p1.Nombre);            
        }

        /// <summary>
        /// Verificamos que se pueda inactivar un usuario.
        /// </summary>
        [Fact]
        public void cambiar_status_de_usuario_mediante_metodo_inactivar()
        {
            Persona p1 = new Persona("X", "leo@correo.ucu.edu.uy", "ZXCV1234"); 
            p1.Inactivar();
            bool actual = p1.Status;

            bool expected = false;

            Assert.Equal(expected.ToString(), actual.ToString());
        }

    }
}
