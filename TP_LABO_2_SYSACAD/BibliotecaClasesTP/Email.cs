using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace BibliotecaClasesTP
{
    public static class Email
    {
        public static void SendEmail(string email, string subjet, string body)
        {
            var smtpCLient = new SmtpClient("smtp.mailgun.org");
            smtpCLient.Port = 587;
            smtpCLient.Credentials = new NetworkCredential("postmaster@sandbox217c677f0d8f4a4f94e3274527247ea5.mailgun.org", "Juba11528836");
            smtpCLient.EnableSsl = true;

            var message = new MailMessage();
            message.From = new MailAddress("postmaster@sandbox217c677f0d8f4a4f94e3274527247ea5.mailgun.org");
            message.To.Add(new MailAddress(email));
            message.Subject = subjet;
            message.Body = body;

            Attachment archivoAdjunto = new Attachment(@"C:\Users\Usuario\Desktop\imagen UTN.png");
            // Agregar el archivo adjunto a la colección de adjuntos del mensaje
            message.Attachments.Add(archivoAdjunto);

            try
            {
                smtpCLient.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine("NO SE ENVIO EL MAIL");
            }
        }

    }
}
