using System;
using System.Net.Mail;

namespace Ignis 
{   
    public class ValidarEmail 
    { 
        /// <summary>
        /// Esta clase recibe un mensaje cuyo parámetro es una dirección de email.
        /// El constructor de MailAddress chequea el formato y retorna si es válido. 
        /// En caso contrario se captura una excepción retornando false.
        /// </summary>
        public bool EsUnEmailValido(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}