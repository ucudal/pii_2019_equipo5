using System;
using System.Text.RegularExpressions;

namespace Ignis 
{   
    public class ValidarEmail 
    { 
        /// <summary>
        /// Esta clase recibe un mensaje cuyo parámetro es una dirección de email ingresada por el usuario.
        /// El método chequea que la dirección esté bien escrita, en caso afirmativo retorna true. 
        /// En caso contrario se retorna false.
        /// </summary>
        public bool EsUnEmailValido(string email) 
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email,expresion)) 
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true; 
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}