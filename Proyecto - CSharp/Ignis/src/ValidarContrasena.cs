using System;
using System.Text.RegularExpressions;

namespace Ignis 
{   
    public class ValidarContrasena  
    { 
        /// <summary>
        /// Método para controlar que la contraseña ingresada tiene un formato válido.
        /// Para este caso, controlamos que no sea 'vacío' y que no sea 'null'
        /// y que el largo sea mayor a 4 carácteres.
        /// Si es necesario, se pueden agregar otras condiciones aquí.
        /// </summary> 
        public bool EsUnaContrasenaValida(string value) 
        {
            if ( (string.IsNullOrEmpty(value)) || (value.Length < 4) ) 
            {
                return false;
            }
            else 
            {
                return true; 
            }
        }
    }
}