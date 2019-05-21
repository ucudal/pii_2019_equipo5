using System;
using Xunit;
using Ignis;

namespace tests
{
    public class testsValidarEmail 
    { 
        /// <summary> 
        /// Testeamos que la clase ValidarEmail realiza el comportamiento esperado.
        /// </summary>

        [Fact]
        public void email_correcto_debe_retornar_true()
        {
            // preparación
            string emailIngresado = "equipo@ucu.edu.uy";
            ValidarEmail ve = new ValidarEmail();
            bool actual = ve.EsUnEmailValido(emailIngresado);

            // esperado
            bool expected = true;

            // test
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void email_incorrecto_debe_retornar_false()
        {
            // preparación
            string emailIngresado = "equipo@ucu.edu.uy";
            ValidarEmail ve = new ValidarEmail();
            bool actual = ve.EsUnEmailValido(emailIngresado);

            // esperado
            bool expected = false;

            // test
            Assert.Equal(expected, actual);
        }
    }
}