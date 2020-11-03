using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCycle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreeCycle.Controllers
{
    public class DonacionesController : Controller
    {
        private readonly DatabaseContext _context;

        public DonacionesController(DatabaseContext context)
        {
            _context = context;
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
        public async Task<IActionResult> CrearSolicitud([Bind("UsuarioId,adress,objeto")]SolicitudDonacion solicitud)
        {
            int flag = 0;
            if (ModelState.IsValid)
            {
                _context.Add(solicitud);
                await _context.SaveChangesAsync();
                 return RedirectToAction("HomePage", "Home", new { flag = 3, UsuarioId=solicitud.UsuarioId });
            }
            
            return View("SolicitudDonacion", solicitud);
        }

        public async Task<IActionResult> ListaDeSolicitudesDeDonaciones(int UsuarioId)
        {
            ViewBag.UsuarioId = UsuarioId;
            var databaseContext = _context.solicitudDonacion.Include(s => s.Usuario);
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

            return View(solicitudDonacion);
        }

    }
}
