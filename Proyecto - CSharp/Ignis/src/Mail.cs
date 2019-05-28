using System;
using System.IO;

namespace Ignis
{ 
    class Mail
     {
            protected string Asunto ;
            protected Persona Remitente;
            protected Persona Destinatario;
            protected string Contenido;

        public Mail(string asunto, string contenido)
        {
            Asunto = asunto;
            Contenido = contenido;
        }

        public Mail (string asunto,Persona remitente, Persona destinatario, string contenido) {
                this.Asunto = asunto;
                this.Remitente = remitente;
                this.Destinatario = destinatario;
                this.Contenido = contenido;

            }

            public void enviar(){
            MailSender mailSender = new MailSender(Remitente.Correo,Remitente.Nombre);  
            mailSender.GetPassword("Ingrese contraseña: ");
            bool sent = mailSender.SendMail(Destinatario.Correo, Asunto, Contenido);
            }        
            
        }
}