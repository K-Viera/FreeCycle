using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace FreeCycle.ViewModels
{
    public class Correos
    {

        public void enviarCorreo(String to, String subject, String body)
        {
            MailMessage mm = new MailMessage();
            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = body;
            mm.From = new MailAddress("freecycledonations@gmail.com");
            //Acá iría true cuando esté hecho con HTML
            mm.IsBodyHtml = false;


            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            //maybe true
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("freecycledonations@gmail.com", "freecycle123");
            smtp.Send(mm);

        }
        



    }
}
