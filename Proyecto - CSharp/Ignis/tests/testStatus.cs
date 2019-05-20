using System;
using Xunit;
using Ignis;

namespace tests
{
    public class testStatus
    {
        /// <summary>
        /// Verificamos la construcción de un objeto STATUS.
        /// </summary>
        [Fact]
        public void construir_un_objeto_status_con_valor_true()
        {
            // preparación.
            Status s1 = new Status(true);
            bool actual = s1.Valor;

            // esperado.
            bool expected = true;

            // test
            Assert.Equal(expected.ToString(), actual.ToString());
        }


        /// <summary>
        /// Verificamos que se pueda inactivar un usuario.
        /// </summary>
        [Fact]
        public void cambiar_status_de_usuario_mediante_metodo_inactivar()
        {
            // preparación.
            Status s1 = new Status(true);   // creo el objeto con valor true.
            s1.Inactivar();                 // cambio el valor mediante el método.
            bool actual = s1.Valor;

            // esperado.
            bool expected = false;

            // test
            Assert.Equal(expected.ToString(), actual.ToString());
        }


        /// <summary>
        /// Verificamos que se pueda activar un usuario.
        /// </summary>
        [Fact]
        public void cambiar_status_de_usuario_mediante_metodo_activar()
        {
            // preparación.
            Status s1 = new Status(false);   // creo el objeto con valor false.
            s1.Activar();                    // cambio el valor mediante el método.
            bool actual = s1.Valor;

            // esperado.
            bool expected = true;

            // test
            Assert.Equal(expected.ToString(), actual.ToString());
        }
    }
}
