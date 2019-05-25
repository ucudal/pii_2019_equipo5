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
            Tecnico t1 = new Tecnico("Gonzalo", "Gonzalo@correo.com", "abc123", 40, "", "", 0, 0);

            string actual = string.Format(@"{0} {1} {2} {3} {4}", t1.Nombre, t1.Correo, t1.Contrasena, t1.Edad, t1.Status);
 
            string expected = "Gonzalo Gonzalo@correo.com abc123 40 True";

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Testeamos el método ActualizarCalif_Clientes.
        /// </summary>
        [Fact]
        public void test_actualizar_calificacion_cliente()
        {
            Tecnico t1 = new Tecnico("Gonzalo", "Gonzalo@correo.com", "abc123", 40, "", "", 0, 0);

            string actual = string.Format(@"{0} {1} {2} {3} {4}", t1.Nombre, t1.Correo, t1.Contrasena, t1.Edad, t1.Status);
 
            string expected = "Gonzalo Gonzalo@correo.com abc123 40 True";

            Assert.Equal(expected, actual);
        }

    }
}
