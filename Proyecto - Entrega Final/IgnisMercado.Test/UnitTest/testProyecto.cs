using System;
using System.Collections.Generic;
using Xunit;
using IgnisMercado.Models;

namespace tests
{
    public class testsProyecto
    {
        /// <summary>
        /// Verificamos la construcción de un objeto Proyecto.
        /// </summary>
        [Fact]
        public void construir_un_proyecto()
        {
            Proyecto proyecto1 = new Proyecto("Proyecto1", "descripcion",true);

            string actual = string.Format(@"{0} {1} {2}", proyecto1.Nombre, proyecto1.Descripcion,proyecto1.Status);
 
            string expected = "Proyecto1 descripcion True";

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Probamos el metodo cerrar, Metodo que cambia el status del proyecto y sus solicitudes asosiadas.
        /// Para ello se necesita tener una solicitud ingresada.
        /// </summary>

        [Fact]
        public void Probar_Metodo_StatusInactivo()
        {
            Proyecto proyecto1 = new Proyecto("Proyecto1", "descripcion",true);
    
            proyecto1.StatusInactivo();
            
            string actual = string.Format(@"{0}", proyecto1.Status);
 
            string expected = "False";

            Assert.Equal(expected, actual);
        }
        
      /// <summary>
      /// Probamos el metodo cerrar, Metodo que calcula el costo total del proyecto para ello se calculan el costo de las solicitudes asosiadas.
      /// Para ello se necesita tener al menos una solicitud ingresada.
      /// </summary>
      
        [Fact]
        public void Probar_StatusActivo()
        {
            Proyecto proyecto1 = new Proyecto("Proyecto1", "descripcion",true);

            proyecto1.StatusActivo();
            
            string actual = string.Format(@"{0}",proyecto1.Status);
 
            string expected = "True";

            Assert.Equal(expected, actual);
        }
    }
}
