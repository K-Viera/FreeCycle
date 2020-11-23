using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCycle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using FreeCycle.ViewModels;

namespace FreeCycle.Controllers
{
    public class DonacionesController : Controller
    {
        private readonly DatabaseContext _context;

        public DonacionesController(DatabaseContext context)
        {
            _context = context;
        }

        public ActionResult OfrecerDonacion(int UsuarioId)
        {
            ViewBag.UsuarioId = UsuarioId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearOfrecimiento([Bind("UsuarioId,adress,estado,objeto")] OfrecerDonacion ofrecimiento)
        {
            int flag = 0;
            if (ModelState.IsValid)
            {
                _context.Add(ofrecimiento);
                await _context.SaveChangesAsync();
                return RedirectToAction("HomePage", "Home", new { flag = 4, UsuarioId = ofrecimiento.UsuarioId });
            }

            return View("OfrecerDonacion", ofrecimiento);
        }

        //Esto le envía el parámetro a la vista directamente???
        public ActionResult SolicitudDonacion(int UsuarioId)
        {
            ViewBag.UsuarioId = UsuarioId;
            return View();
        }

        //flag 3 para registro de solicitud de donación exitoso
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearSolicitud([Bind("UsuarioId,adress,objeto")] SolicitudDonacion solicitud)
        {
            int flag = 0;
            if (ModelState.IsValid)
            {
                _context.Add(solicitud);
                await _context.SaveChangesAsync();
                return RedirectToAction("HomePage", "Home", new { flag = 3, UsuarioId = solicitud.UsuarioId });
            }

            return View("SolicitudDonacion", solicitud);
        }

        public async Task<IActionResult> ListaDeSolicitudesDeDonaciones(int UsuarioId)
        {
            ViewBag.UsuarioId = UsuarioId;
            var databaseContext = _context.solicitudDonacion.Include(s => s.Usuario);
            return View(await databaseContext.ToListAsync());
        }

        public async Task<IActionResult> ListaDeOfrecerDonaciones(int UsuarioId)
        {
            ViewBag.UsuarioId = UsuarioId;
            var databaseContext = _context.ofrecerDonacion.Include(s => s.Usuario);
            return View(await databaseContext.ToListAsync());
        }


        public async Task<IActionResult> DetallesDeSolicitudesDeDonaciones(int? id, int UsuarioId)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.UsuarioId = UsuarioId;
            var solicitudDonacion = await _context.solicitudDonacion
                .Include(s => s.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudDonacion == null)
            {
                return NotFound();
            }

            if(UsuarioId == solicitudDonacion.UsuarioId)
            {
                return View("DetallesDeMiSolicitud",solicitudDonacion);
            }

            return View(solicitudDonacion);
        }

        public async Task<IActionResult> DetallesDeOfertasDeDonaciones(int? id, int UsuarioId)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.UsuarioId = UsuarioId;
            var ofertaDonacion = await _context.ofrecerDonacion
                .Include(s => s.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ofertaDonacion == null)
            {
                return NotFound();
            }
            if (UsuarioId == ofertaDonacion.UsuarioId)
            {
                return View("DetallesDeMiOferta", ofertaDonacion);
            }

            return View(ofertaDonacion);
        }


        [HttpPost]
        public ActionResult DetallesDeSolicitudesDeDonaciones(string Email,int Id,string descripcion)
        {
            var Usuario = _context.Usuario.FirstOrDefault(user => user.Id == Id);
            Correos c = new Correos();
            if (Usuario != null && Email!=null)
            {
                string donante = Usuario.Email.ToString();
                string objeto = descripcion;         

                string to = Email;
                string subject = "Possible donor";

                //Mejorar este mensaje y ponerlo con HTML
                string body = "Hello, the user: " +donante +" is interested in donating you the request: "+objeto+ ", that you posted in our page, please send him an email him with the details to the place were you can deal the donation.";

                c.enviarCorreo(to,subject,body);
                
                ViewBag.Email = Email;
                return RedirectToAction("HomePage", "Home", new { flag = 5, UsuarioId = Usuario.Id, Usuario.Email });

            }
            else
            {
                //Enviar VB de usuario no registrado
            }
            return View();
        }

        [HttpPost]
        public ActionResult DetallesDeOfertasDeDonaciones(string Email, int Id, string descripcion)
        {
            var Usuario = _context.Usuario.FirstOrDefault(user => user.Id == Id);
            Correos c = new Correos();
            if (Usuario != null)
            {
                string solicitante = Usuario.Email.ToString();
                string objeto = descripcion;

                string to = Email;
                string subject = "Possible petitioner";

                //Mejorar este mensaje y ponerlo con HTML
                string body = "Hello, the user: " + solicitante + " is interested in taking your request: " + objeto + ", that you posted in our page, please send him an email him with the details to the place were you can deal the donation.";

                c.enviarCorreo(to, subject, body);

                return RedirectToAction("HomePage", "Home", new { flag = 5, UsuarioId = Usuario.Id, Usuario.Email });
            }
            else
            {
                //Enviar VB de usuario no registrado
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DetallesDeMiSolicitud(int Id, int UsuarioId)
        {
            var solicitudDonacion = _context.solicitudDonacion.FirstOrDefault(solicitud => solicitud.Id == Id);
            if (solicitudDonacion != null)
            {
                _context.Remove(solicitudDonacion);
                await _context.SaveChangesAsync();
                return RedirectToAction("HomePage", "Home", new { flag = 6, UsuarioId = UsuarioId});
            }

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> DetallesDeMiOferta(int Id, int UsuarioId)
        {
            var ofertaDonacion = _context.ofrecerDonacion.FirstOrDefault(oferta => oferta.Id == Id);
            if (ofertaDonacion != null)
            {
                _context.Remove(ofertaDonacion);
                await _context.SaveChangesAsync();
                return RedirectToAction("HomePage", "Home", new { flag = 7, UsuarioId = UsuarioId });
            }

            return View();
        }


    }
}
