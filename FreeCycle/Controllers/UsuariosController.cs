using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FreeCycle.Models;
using System.Net.Mail;
using System.Security.Cryptography.Xml;
using System.Text;



namespace FreeCycle.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly DatabaseContext _context;
        public IActionResult Create()
        {
            return View();
        }
       
        public UsuariosController(DatabaseContext context)
        {
            _context = context;
        }

        //Flag 0 para email ya registrado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Password,PhoneNumber,Email")] Usuario usuario)
        {
            int flag;
            String temp = usuario.Email;
            var Usuario = _context.Usuario.FirstOrDefault(user => user.Email == temp);
            if (Usuario == null)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("GoToIndex", "Home", new { flag = 3 });
                }
                
            }
            flag = 0;
            ViewBag.flag = flag;
            return View(usuario);
        }

        public IActionResult RecuperarContraseña()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RecuperarContraseña(string Email)
        {
            var Usuario = _context.Usuario.FirstOrDefault(user => user.Email == Email);
            if(Usuario  != null)
            {
                string strToken = Usuario.Email.ToString();
                //ACÁ SE DEBERÍA ENCRIPTAR EL EMAIL
                string strTokenAjax;
                //Acá se debería adquirir la dirección de una mejor forma
                var address = "https://localhost:44358/Usuarios/CambiarContraseña/?tkn="+ strToken;

                string to = Email;
                string subject = "PASSWORD RECOVERY URGENT";

                //Mejorar este mensaje y ponerlo con HTML
                string body = "Jelou jaguar yu, pa recuperar la contra pai vaya para " + address + " Un saludo";

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

                //No es necesario se puede manejar con una flag tipica
                ViewBag.Email = Email;
                
            }
            else
            {
                //Enviar VB de usuario no registrado
            }
            return View();
        }


      


    }
}
